# Category PowerSync proof of concept

Category is the only SMIS entity currently moved to PowerSync. Other entities
continue to use the existing synchronization implementation.

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
- `ShopId`: authenticated user's shop
- `aud`: PowerSync Development instance URL
- `iat` / `exp`: short-lived token timestamps

The Category Sync Stream uses the trusted `ShopId` claim:

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
- Category CDC replication
- `shop_categories` Sync Stream
- custom RS256 JWT verification with a public JWKS key
- temporary/development PowerSync tokens disabled

ASP.NET keeps the RSA private key in deployment configuration. PowerSync Cloud
stores only the public key. Flutter never receives either signing key.
