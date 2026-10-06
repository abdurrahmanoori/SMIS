class PurchaseOrder {
  const PurchaseOrder({
    required this.id,
    required this.shopId,
    required this.supplierId,
    required this.supplierName,
    required this.orderedAtUtc,
    required this.status,
    required this.lines,
    this.referenceNumber,
    this.notes,
  });

  final String id;
  final String shopId;
  final String supplierId;
  final String supplierName;
  final DateTime orderedAtUtc;
  final String status;
  final String? referenceNumber;
  final String? notes;
  final List<PurchaseOrderLine> lines;

  bool get isCancelled => status.toLowerCase() == 'cancelled';

  bool get hasReceipts => lines.any((line) => line.receivedQuantity > 0);

  factory PurchaseOrder.fromJson(Map<String, dynamic> json) => PurchaseOrder(
    id: json['id'] as String,
    shopId: json['shopId'] as String,
    supplierId: json['supplierId'] as String,
    supplierName: json['supplierName'] as String? ?? '',
    orderedAtUtc: DateTime.parse(json['orderedAtUtc'] as String),
    status: (json['status'] ?? '').toString(),
    referenceNumber: json['referenceNumber'] as String?,
    notes: json['notes'] as String?,
    lines: (json['lines'] as List<dynamic>? ?? const [])
        .map(
          (item) => PurchaseOrderLine.fromJson(
            Map<String, dynamic>.from(item as Map),
          ),
        )
        .toList(),
  );
}

class PurchaseOrderLine {
  const PurchaseOrderLine({
    required this.id,
    required this.productId,
    required this.productName,
    required this.productUnitId,
    required this.orderedQuantity,
    required this.receivedQuantity,
    required this.returnedQuantity,
    required this.remainingQuantity,
    required this.netReceivedQuantity,
    required this.unitCostBase,
  });

  final String id;
  final String productId;
  final String productName;
  final String productUnitId;
  final double orderedQuantity;
  final double receivedQuantity;
  final double returnedQuantity;
  final double remainingQuantity;
  final double netReceivedQuantity;
  final int unitCostBase;

  factory PurchaseOrderLine.fromJson(Map<String, dynamic> json) =>
      PurchaseOrderLine(
        id: json['id'] as String,
        productId: json['productId'] as String,
        productName: json['productName'] as String? ?? '',
        productUnitId: json['productUnitId'] as String,
        orderedQuantity: (json['orderedQuantityEntered'] as num).toDouble(),
        receivedQuantity: (json['receivedQuantityEntered'] as num).toDouble(),
        returnedQuantity: (json['returnedQuantityEntered'] as num).toDouble(),
        remainingQuantity: (json['remainingToReceiveQuantityEntered'] as num)
            .toDouble(),
        netReceivedQuantity: (json['netReceivedQuantityEntered'] as num)
            .toDouble(),
        unitCostBase: (json['unitCostBase'] as num).toInt(),
      );
}
