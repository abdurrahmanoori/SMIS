param(
    [switch]$Apply,
    [switch]$Verify,
    [switch]$AllowSessionActivity,
    [string]$BackupDirectory = ".tmp/grocery-seed-backup"
)
$ErrorActionPreference = "Stop"
$root = Split-Path (Split-Path $PSScriptRoot -Parent) -Parent
Set-Location $root
$config = Get-Content "SMIS.Api/appsettings.Production.json" -Raw | ConvertFrom-Json
$connection = New-Object System.Data.SqlClient.SqlConnection($config.ConnectionStrings.DefaultConnection)
$connection.Open()
# Child-first allowlist; identity, ownership, languages, migrations and CDC are never reset.
$tables = @("LoanAccountPayment","LoanAccount","SaleLine","Sale","StockCountLine",
    "StockCountSession","StockMovement","StockBatch","PurchaseOrderLine","PurchaseOrder",
    "ProductPrice","ProductUnit","Product","Category","Supplier","Customers",
    "ProvinceTranslations","Districts","Provinces","UnitOfMeasure",
    "LocalizedTextTranslation","LocalizedText","IdempotencyRecord","AppLogs","Shop")
$protected = @("AspNetUsers","AspNetRoles","AspNetUserRoles","AspNetUserClaims",
    "AspNetRoleClaims","AspNetUserLogins","AspNetUserTokens","ApplicationComponents",
    "ApplicationTasks","RoleComponentPermissions","RoleTaskPermissions",
    "ApplicationRefreshTokens","ShopOwner","Languages")
function Read-Json([string]$table, $transaction) {
    $cmd = $connection.CreateCommand()
    if ($transaction) { $cmd.Transaction = $transaction }
    $cmd.CommandText = "SELECT * FROM dbo.[$table] ORDER BY (SELECT NULL) FOR JSON PATH, INCLUDE_NULL_VALUES"
    $reader = $cmd.ExecuteReader()
    $builder = New-Object System.Text.StringBuilder
    while ($reader.Read()) { [void]$builder.Append($reader.GetString(0)) }
    $reader.Close()
    # Normalize row order before hashing.
    $rows = @(ConvertFrom-Json $builder.ToString())
    return ConvertTo-Json -InputObject @($rows | Sort-Object { $_ | ConvertTo-Json -Compress -Depth 30 }) -Compress -Depth 30
}
function Fingerprints($transaction) {
    $result = @{}
    foreach ($table in $protected) {
        $bytes = [Text.Encoding]::UTF8.GetBytes((Read-Json $table $transaction))
        $sha = [Security.Cryptography.SHA256]::Create()
        $result[$table] = [BitConverter]::ToString($sha.ComputeHash($bytes)).Replace("-","")
        $sha.Dispose()
    }
    return $result
}
try {
    if ($connection.Database -ne "smis" -or $connection.DataSource -notlike "*noori-sql-2026*") {
        throw "Unexpected Azure database. Reset refused."
    }
    if ($Verify) {
        $baseline = Get-Content (Join-Path $BackupDirectory "protected-fingerprints.json") -Raw | ConvertFrom-Json
        $actual = Fingerprints $null
        $failures = @()
        foreach ($table in $protected) {
            if ($baseline.$table -ne $actual[$table]) {
                if ($AllowSessionActivity -and $table -eq "ApplicationRefreshTokens") {
                    Write-Output "Refresh-token fingerprint differs; session activity must be checked separately. Seeder never writes this table."
                } else { $failures += $table }
            }
        }
        if ($failures.Count -gt 0) { throw ("Protected tables changed: " + ($failures -join ", ")) }
        Write-Output "Protected-table verification passed. Any allowed session difference is reported above."
        return
    }
    if (!$Apply) { Write-Output "Dry run: business tables only; referenced shops, ownership, identity and languages retained."; return }
    if (Test-Path $BackupDirectory) { throw "Backup directory already exists. Use a new directory for a new reset." }
    New-Item -ItemType Directory -Path $BackupDirectory | Out-Null
    $transaction = $connection.BeginTransaction([System.Data.IsolationLevel]::Serializable)
    try {
        $before = Fingerprints $transaction
        foreach ($table in $tables) {
            Read-Json $table $transaction | Set-Content (Join-Path $BackupDirectory "$table.json") -Encoding UTF8
        }
        $before | ConvertTo-Json | Set-Content (Join-Path $BackupDirectory "protected-fingerprints.json") -Encoding UTF8
        # Keep dependency rows required by protected ownership and user assignments.
        $sql = @"
DELETE FROM dbo.LoanAccountPayment;
DELETE FROM dbo.LoanAccount;
DELETE FROM dbo.SaleLine;
DELETE FROM dbo.Sale;
DELETE FROM dbo.StockCountLine;
DELETE FROM dbo.StockCountSession;
DELETE FROM dbo.StockMovement;
DELETE FROM dbo.StockBatch;
DELETE FROM dbo.PurchaseOrderLine;
DELETE FROM dbo.PurchaseOrder;
DELETE FROM dbo.ProductPrice;
DELETE FROM dbo.ProductUnit;
DELETE FROM dbo.Product;
DELETE FROM dbo.Category;
DELETE FROM dbo.Supplier;
DELETE FROM dbo.Customers;
DELETE pt FROM dbo.ProvinceTranslations pt WHERE NOT EXISTS (SELECT 1 FROM dbo.ShopOwner o WHERE o.ProvinceId=pt.ProvinceId)
AND NOT EXISTS (SELECT 1 FROM dbo.ShopOwner o JOIN dbo.Districts d ON d.Id=o.DistrictId WHERE d.ProvinceId=pt.ProvinceId);
DELETE d FROM dbo.Districts d WHERE NOT EXISTS (SELECT 1 FROM dbo.ShopOwner o WHERE o.DistrictId=d.Id);
DELETE p FROM dbo.Provinces p WHERE NOT EXISTS (SELECT 1 FROM dbo.ShopOwner o WHERE o.ProvinceId=p.Id)
AND NOT EXISTS (SELECT 1 FROM dbo.Districts d WHERE d.ProvinceId=p.Id);
DELETE FROM dbo.UnitOfMeasure;
DELETE FROM dbo.LocalizedTextTranslation;
DELETE FROM dbo.LocalizedText;
DELETE FROM dbo.IdempotencyRecord;
DELETE FROM dbo.AppLogs;
DELETE s FROM dbo.Shop s WHERE NOT EXISTS (SELECT 1 FROM dbo.AspNetUsers u WHERE u.ShopId=s.Id)
AND NOT EXISTS (SELECT 1 FROM dbo.ShopOwner o WHERE o.ShopId=s.Id);
"@
        $cmd = $connection.CreateCommand()
        $cmd.Transaction = $transaction
        $cmd.CommandTimeout = 120
        $cmd.CommandText = $sql
        [void]$cmd.ExecuteNonQuery()
        $after = Fingerprints $transaction
        foreach ($table in $protected) { if ($before[$table] -ne $after[$table]) { throw "Protected data changed: $table" } }
        $transaction.Commit()
        Write-Output "Business reset committed. Backup: $BackupDirectory. Protected fingerprints unchanged."
    } catch {
        $transaction.Rollback()
        throw
    }
} finally { $connection.Dispose() }
