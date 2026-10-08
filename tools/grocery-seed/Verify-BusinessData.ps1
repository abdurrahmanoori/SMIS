param([string]$OutputPath = ".tmp/grocery-seed-verification.json")
$ErrorActionPreference = "Stop"
$root = Split-Path (Split-Path $PSScriptRoot -Parent) -Parent
Set-Location $root
$config = Get-Content "SMIS.Api/appsettings.Production.json" -Raw | ConvertFrom-Json
$connection = New-Object System.Data.SqlClient.SqlConnection($config.ConnectionStrings.DefaultConnection)
try {
    $connection.Open()
    $cmd = $connection.CreateCommand()
    $cmd.CommandText = Get-Content (Join-Path $PSScriptRoot "Verify-BusinessData.sql") -Raw
    $cmd.CommandTimeout = 60
    $adapter = New-Object System.Data.SqlClient.SqlDataAdapter($cmd)
    $data = New-Object System.Data.DataSet
    [void]$adapter.Fill($data)
    $checks = @($data.Tables[0].Rows | ForEach-Object { @{ CheckName=$_.CheckName; Violations=[int]$_.Violations } })
    $shops = @($data.Tables[1].Rows | ForEach-Object {
        @{ Id=$_.Id; Name=$_.Name; Categories=[int]$_.Categories; Products=[int]$_.Products;
           Suppliers=[int]$_.Suppliers; Batches=[int]$_.Batches; Movements=[int]$_.Movements;
           PurchaseOrders=[int]$_.PurchaseOrders; StockCounts=[int]$_.StockCounts }
    })
    @{ CheckedAtUtc=[DateTime]::UtcNow.ToString("o"); Checks=$checks; Shops=$shops } |
        ConvertTo-Json -Depth 8 | Set-Content $OutputPath -Encoding UTF8
    $checks | ForEach-Object { Write-Output ($_.CheckName + ": " + $_.Violations) }
    if (@($checks | Where-Object { $_.Violations -ne 0 }).Count -gt 0) { throw "Business integrity violations found." }
    if ($shops.Count -ne 5) { throw "Expected five shops." }
    foreach ($shop in $shops) {
        if ($shop.Products -ne 20 -or $shop.Categories -ne 12 -or $shop.Suppliers -ne 3 -or
            $shop.Batches -ne 20 -or $shop.Movements -ne 20 -or $shop.PurchaseOrders -ne 3 -or $shop.StockCounts -ne 1) {
            throw "Unexpected shop totals: $($shop.Name)"
        }
    }
    Write-Output "All business checks and five-shop totals passed."
} finally { $connection.Dispose() }
