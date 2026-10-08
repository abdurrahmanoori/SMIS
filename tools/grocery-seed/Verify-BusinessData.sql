-- Read-only post-seed invariants; each violation count must be zero.
SELECT 'Stock ledger mismatch' AS CheckName, COUNT(*) AS Violations
FROM dbo.StockBatch b
OUTER APPLY (
    SELECT SUM(CASE WHEN m.Direction='In' THEN m.QuantityBase ELSE -m.QuantityBase END) AS Balance
    FROM dbo.StockMovement m WHERE m.StockBatchId=b.Id
) ledger
WHERE b.RemainingQuantityBase <> COALESCE(ledger.Balance,0)
UNION ALL
SELECT 'Invalid stock balance', COUNT(*) FROM dbo.StockBatch
WHERE RemainingQuantityBase < 0 OR RemainingQuantityBase > ReceivedQuantityBase
UNION ALL
SELECT 'Invalid receipt conversion', COUNT(*)
FROM dbo.StockBatch b JOIN dbo.ProductUnit u ON u.Id=b.ReceivedProductUnitId
WHERE b.ReceivedQuantityBase <> b.ReceivedQuantity*u.BaseUnitQuantity
UNION ALL
SELECT 'Missing base product unit', COUNT(*) FROM dbo.Product p
WHERE NOT EXISTS (SELECT 1 FROM dbo.ProductUnit u WHERE u.ProductId=p.Id AND u.UnitOfMeasureId=p.BaseUnitId AND u.BaseUnitQuantity=1)
UNION ALL
SELECT 'Invalid product-unit conversion', COUNT(*) FROM dbo.ProductUnit WHERE BaseUnitQuantity<=0
UNION ALL
SELECT 'Cross-shop product category', COUNT(*)
FROM dbo.Product p JOIN dbo.Category c ON c.Id=p.CategoryId WHERE p.ShopId<>c.ShopId
UNION ALL
SELECT 'Cross-shop purchase supplier', COUNT(*)
FROM dbo.PurchaseOrder p JOIN dbo.Supplier s ON s.Id=p.SupplierId WHERE p.ShopId<>s.ShopId
UNION ALL
SELECT 'Invalid purchase line relationship', COUNT(*)
FROM dbo.PurchaseOrderLine l JOIN dbo.PurchaseOrder o ON o.Id=l.PurchaseOrderId
JOIN dbo.Product p ON p.Id=l.ProductId JOIN dbo.ProductUnit u ON u.Id=l.ProductUnitId
WHERE p.ShopId<>o.ShopId OR u.ProductId<>p.Id
UNION ALL
SELECT 'Invalid stock relationship', COUNT(*)
FROM dbo.StockBatch b JOIN dbo.Product p ON p.Id=b.ProductId
JOIN dbo.ProductUnit u ON u.Id=b.ReceivedProductUnitId
WHERE b.ShopId<>p.ShopId OR u.ProductId<>p.Id
UNION ALL
SELECT 'Overlapping price periods', COUNT(*)
FROM dbo.ProductPrice a JOIN dbo.ProductPrice b ON a.ProductUnitId=b.ProductUnitId AND a.Id<b.Id
WHERE a.EffectiveDate<=COALESCE(b.EndDate,'9999-12-31') AND b.EffectiveDate<=COALESCE(a.EndDate,'9999-12-31')
UNION ALL
SELECT 'Missing current product price', COUNT(*) FROM dbo.ProductUnit u
WHERE NOT EXISTS (SELECT 1 FROM dbo.ProductPrice p WHERE p.ProductUnitId=u.Id AND p.EffectiveDate<=SYSUTCDATETIME()
AND (p.EndDate IS NULL OR p.EndDate>=SYSUTCDATETIME()))
UNION ALL
SELECT 'Invalid physical stock count', COUNT(*) FROM dbo.StockCountLine
WHERE CountedQuantityBase IS NULL OR CountedQuantityBase<>ExpectedQuantityBase
UNION ALL
SELECT 'Unreceived purchase quantity', COUNT(*) FROM dbo.PurchaseOrderLine
WHERE OrderedQuantityEntered<>ReceivedQuantityEntered OR ReturnedQuantityEntered<>0
UNION ALL
SELECT 'Stale product shop label', COUNT(*) FROM dbo.Product p JOIN dbo.Shop s ON s.Id=p.ShopId
WHERE p.ShopName<>s.Name
UNION ALL
SELECT 'Stale product category label', COUNT(*) FROM dbo.Product p JOIN dbo.Category c ON c.Id=p.CategoryId
WHERE p.CategoryName<>c.Name
UNION ALL
SELECT 'Stale user shop label', COUNT(*) FROM dbo.AspNetUsers u JOIN dbo.Shop s ON s.Id=u.ShopId
WHERE u.ShopName<>s.Name
UNION ALL
SELECT 'Stale owner shop label', COUNT(*) FROM dbo.ShopOwner o JOIN dbo.Shop s ON s.Id=o.ShopId
WHERE o.ShopName<>s.Name
UNION ALL
SELECT 'Selling price below received cost', COUNT(*)
FROM dbo.ProductPrice p JOIN dbo.ProductUnit u ON u.Id=p.ProductUnitId
JOIN dbo.StockBatch b ON b.ProductId=u.ProductId
WHERE p.SellPrice<b.UnitCostBase*u.BaseUnitQuantity;
SELECT s.Id, s.Name,
(SELECT COUNT(*) FROM dbo.Category c WHERE c.ShopId=s.Id) AS Categories,
(SELECT COUNT(*) FROM dbo.Product p WHERE p.ShopId=s.Id) AS Products,
(SELECT COUNT(*) FROM dbo.Supplier u WHERE u.ShopId=s.Id) AS Suppliers,
(SELECT COUNT(*) FROM dbo.StockBatch b WHERE b.ShopId=s.Id) AS Batches,
(SELECT COUNT(*) FROM dbo.StockMovement m WHERE m.ShopId=s.Id) AS Movements,
(SELECT COUNT(*) FROM dbo.PurchaseOrder o WHERE o.ShopId=s.Id) AS PurchaseOrders,
(SELECT COUNT(*) FROM dbo.StockCountSession c WHERE c.ShopId=s.Id) AS StockCounts
FROM dbo.Shop s ORDER BY s.Name;
