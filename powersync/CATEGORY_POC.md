# Flutter PowerSync gradual migration

PowerSync is intentionally scoped to data that currently has an offline Flutter
use case. In addition to the business entities used by Flutter, active language
lookup rows and the signed-in user's language preference are synchronized so
locale selection remains consistent with the server account.

## Authentication flow

Flutter stores only the normal SMIS login token in secure storage.

When PowerSync needs credentials, `CategoryPowerSyncConnector.fetchCredentials()`
calls the authenticated ASP.NET endpoint:

`GET /api/PowerSync/credentials`

ASP.NET derives the current `UserId` and `ShopId` from the authenticated SMIS
session and returns a short-lived PowerSync JWT. The token expires after five
minutes and is not persisted by the application. The PowerSync SDK caches it
internally and calls `fetchCredentials()` again when fresh credentials are
needed.

The PowerSync JWT contains:

- `sub`: authenticated SMIS user ID
- `UserId`: authenticated SMIS user ID used by the current-user sync stream
- `ShopId`: authenticated user's shop
- `aud`: PowerSync Development instance URL
- `iat` / `exp`: short-lived token timestamps

## Active shop context

Regular users are permanently scoped to the `ShopId` in their normal SMIS
access token. A SuperAdmin may change that context through the authenticated
`POST /api/Account/switch-shop` endpoint. The backend validates that the target
shop exists and is active, then issues a fresh normal SMIS access token whose
`ShopId` claim is the selected shop. Flutter never edits JWT claims locally and
the persisted `ApplicationUser.ShopId` is not changed by switching context.

Shop-owned EF Core query filters always use the active token `ShopId`, including
for SuperAdmin users. SuperAdmin privilege grants the ability to choose a shop;
it does not bypass tenant filtering for ordinary Category/Product/ProductUnit
operations.

Flutter stores PowerSync databases per user and active shop:

`smis_powersync_<userId>_<shopId>.db`

Before switching, Flutter refuses the operation while the current context has
pending PowerSync writes. It then closes the previous sync database, stores the
new server-issued access token, opens the selected shop's database, reconnects
PowerSync, waits for the new context to synchronize, and refreshes shop-scoped
controllers. Global UnitOfMeasure data remains global even though each shop
context has its own isolated local cache.

Shop-scoped streams use the trusted `ShopId` claim. The Shop stream additionally
uses the trusted `IsSuperAdmin` claim so platform administrators can receive all
shops while ordinary users receive only their own shop.

```sql
WHERE category."ShopId" = auth.parameter('ShopId')
  AND category."IsDeleted" = 0
```

## Write flow

Category writes happen locally first in the PowerSync SQLite database. PowerSync
queues the mutation. `uploadData()` later sends the mutation through the normal
SMIS Category endpoints (`POST`, `PUT`, `DELETE /api/Category`). Those requests
use the normal SMIS bearer token; the PowerSync JWT is only for connecting to
the PowerSync service.

## PowerSync Cloud

The Development instance is configured with:

- Azure SQL `smis` as the source database
- CDC replication for the Flutter-synchronized business tables plus Languages
  and AspNetUsers
- explicit streams for the Flutter business data, active languages, and the
  signed-in user's language preference
- custom RS256 JWT verification with a public JWKS key
- temporary/development PowerSync tokens disabled

ASP.NET keeps the RSA private key in deployment configuration. PowerSync Cloud
stores only the public key. Flutter never receives either signing key.
