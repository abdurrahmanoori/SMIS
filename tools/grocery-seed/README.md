# Afghan grocery API seed

Realistic **fictional** grocery data, with bilingual English/Dari names and illustrative AFN prices. Prices are not verified market quotes. No real supplier telephone numbers, tax registrations or manufactured branded barcodes are invented.

## Scope

Five shops, twelve categories and twenty products per shop, six shared measurement/packaging units, two units and two current prices per product, three suppliers and three fully received purchase orders per shop. Receipt APIs generate twenty stock batches and matching purchase-receipt movements per shop. Each shop also has a completed physical stock count. Four provinces and four city districts support Flutter location management.

Only Flutter-supported business modules are populated. Customer, sales and loan modules currently have no Flutter screens and are cleared without fabricated transactions.

Categories each describe one group: Rice, Flour, Pulses, Cooking oil, Sugar, Tea, Spices, Dairy, Eggs, Packaged food, Beverages and Cleaning supplies. English/Dari labels name the same group in two languages.

For an already seeded version-one dataset, apply the category-only API correction instead of resetting stock:

```powershell
python tools/grocery-seed/correct_categories.py --base-url https://api-smis.runasp.net --session .tmp/grocery-seed-session.json
```

This utility saves before-images and progress to `.tmp/grocery-category-correction.json`, updates categories and their product assignments, and refreshes cached category labels. Units, prices, purchase receipts and stock stay intact. Tea currently represents sealed 250 g/500 g packets counted individually; a kilogram base with packet conversions requires a separate coordinated inventory conversion. The revised recipe uses a version check to prevent replaying an old seed journal under changed definitions.

Four existing shop IDs and names are retained because users/ownership reference them and store cached shop labels. Their business addresses are updated through the Shop API; a fifth shop is created. User assignments and ShopOwner rows stay intact. No owners or user accounts are invented for the fifth shop; an existing SuperAdmin can select it.

## Reset

Run from the repository root. The PowerShell utility reads the existing Production connection configuration without printing credentials.

```powershell
# Default: inspect the scope without changing data.
powershell -NoProfile -File tools/grocery-seed/Reset-BusinessData.ps1

# Child-first, transactional business reset; exports pre-reset business JSON first.
powershell -NoProfile -File tools/grocery-seed/Reset-BusinessData.ps1 -Apply

# Compare all fifteen protected-table fingerprints.
powershell -NoProfile -File tools/grocery-seed/Reset-BusinessData.ps1 -Verify
```

The default backup is `.tmp/grocery-seed-backup`. Keep it outside version control. A second reset requires a new `-BackupDirectory`; existing backups cannot be overwritten. Referential constraints remain enabled. Shop and location rows required by protected ownership/identity are retained.

The reset uses SQL because normal APIs intentionally lack hard-delete operations for stock ledger history. **Every replacement row is inserted through existing API business operations**, not SQL. Migrations, CDC and PowerSync internal state are preserved.

Backups contain business-row JSON, not a complete Azure database backup or an automatic restore command. Restoring requires replaying the saved rows in dependency order, preserving IDs and conversions; involve database administration for a full recovery. The reset is atomic; the multi-request API seed is not one database transaction.

## Seed

Python 3.12 standard library only. Obtain a valid SuperAdmin login response privately and save it as JSON; do not commit it. The seeder reads only its access token, never changes credentials/roles and never logs tokens. Normal authentication can create session records; take protected fingerprints after authentication.

```powershell
python tools/grocery-seed/seed_groceries.py --base-url https://api-smis.runasp.net --session .tmp/grocery-seed-session.json --preflight
python tools/grocery-seed/seed_groceries.py --base-url https://api-smis.runasp.net --session .tmp/grocery-seed-session.json
powershell -NoProfile -File tools/grocery-seed/Reset-BusinessData.ps1 -Verify
powershell -NoProfile -File tools/grocery-seed/Verify-BusinessData.ps1
```

The hosted Shop IDs must match the retained Azure IDs before writes. Preflight checks required API reads; reset fingerprints independently validate preservation. Do not run other business writers during the reset/seed.

The verification script checks ledger balances, package conversions, cross-shop relationships, price overlap/coverage, cost-versus-price validity, cached shop labels, physical counts and expected totals. It saves read-only results to `.tmp/grocery-seed-verification.json`.

Strict protected verification also compares refresh tokens. If a separate logged-in client refreshes its session during seeding, verify that activity independently using token timestamps, then use `-Verify -AllowSessionActivity` to validate the other fourteen protected tables while explicitly reporting the session-table difference. This option never writes session data or rewrites the baseline.

Province creation supplies explicit existing English LanguageId translations. The current backend fallback for a name-only province uses the nonexistent language ID `1`; this seeder avoids that failing path without changing the backend. Stock-count completion uses the server's timestamp so it cannot precede the start time.

`.tmp/grocery-seed-state.json` stores generated IDs and completed operations. Reruns with the same journal skip successful writes. A write interrupted after possible server commit is marked pending and stops resumption until its API result is reconciled; it is never blindly retried. Purchase orders/receipts also carry API idempotency keys. Use a new journal after a fresh reset. Access tokens must remain valid; shop selection returns a fresh shop-scoped token without changing stored user ShopId.

Bulk goods use kilograms with product-specific sacks/bags. Packaged goods use individual pieces (explicit package size in the product name), with carton/tray conversions. Examples: rice sack = 25 kg, flour sack = 50 kg, egg tray = 30 eggs, oil carton = four 5 L bottles. Unit cost is AFN per base unit; selling price is AFN per selected unit. All stock balances originate from receipts. Dairy has short future expiry dates; household products have no expiration date.

Open offline clients may have pending writes containing deleted IDs. Review/discard obsolete pending changes and refresh their local synchronized data before using the replacement dataset.
