import 'package:flutter/material.dart';

import '../l10n/app_localizations.dart';
import '../models/product.dart';
import '../models/product_price.dart';
import '../models/product_unit.dart';
import '../models/unit_of_measure.dart';

class ProductPriceFormDialog extends StatefulWidget {
  const ProductPriceFormDialog({
    super.key,
    required this.productUnits,
    required this.products,
    required this.units,
    this.productPrice,
  });

  final List<ProductUnit> productUnits;
  final List<Product> products;
  final List<UnitOfMeasure> units;
  final ProductPrice? productPrice;

  @override
  State<ProductPriceFormDialog> createState() => _ProductPriceFormDialogState();
}

class _ProductPriceFormDialogState extends State<ProductPriceFormDialog> {
  final _formKey = GlobalKey<FormState>();
  late final TextEditingController _sellPrice;
  String? _productUnitId;
  late DateTime _effectiveDate;
  DateTime? _endDate;

  bool get _isEditing => widget.productPrice != null;

  @override
  void initState() {
    super.initState();
    _productUnitId = widget.productPrice?.productUnitId;
    _sellPrice = TextEditingController(
      text: widget.productPrice?.sellPrice.toString() ?? '',
    );
    _effectiveDate =
        widget.productPrice?.effectiveDate.add(const Duration(seconds: 1)) ??
        DateTime.now().toUtc();
    _endDate = null;
  }

  @override
  void dispose() {
    _sellPrice.dispose();
    super.dispose();
  }

  String _productName(String productId) {
    for (final product in widget.products) {
      if (product.id == productId) return product.name;
    }
    return productId;
  }

  String _unitName(String unitId) {
    for (final unit in widget.units) {
      if (unit.id == unitId) return unit.name;
    }
    return unitId;
  }

  String _productUnitLabel(ProductUnit productUnit) =>
      '${_productName(productUnit.productId)} - '
      '${_unitName(productUnit.unitOfMeasureId)}';

  Future<void> _pickEffectiveDate() async {
    final picked = await showDatePicker(
      context: context,
      initialDate: _effectiveDate.toLocal(),
      firstDate: DateTime(2000),
      lastDate: DateTime(2100),
    );
    if (picked == null || !mounted) return;
    setState(() {
      _effectiveDate = DateTime(
        picked.year,
        picked.month,
        picked.day,
        _effectiveDate.hour,
        _effectiveDate.minute,
        _effectiveDate.second,
      ).toUtc();
    });
  }

  Future<void> _pickEndDate() async {
    final initial = (_endDate ?? _effectiveDate).toLocal();
    final picked = await showDatePicker(
      context: context,
      initialDate: initial,
      firstDate: _effectiveDate.toLocal(),
      lastDate: DateTime(2100),
    );
    if (picked == null || !mounted) return;
    setState(() {
      _endDate = DateTime(
        picked.year,
        picked.month,
        picked.day,
        23,
        59,
        59,
      ).toUtc();
    });
  }

  @override
  Widget build(BuildContext context) => AlertDialog(
    title: Text(
      context.l10n.text(
        _isEditing ? 'Add successor price' : 'New product price',
      ),
    ),
    content: SizedBox(
      width: 520,
      child: Form(
        key: _formKey,
        child: SingleChildScrollView(
          child: Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              DropdownButtonFormField<String>(
                initialValue: _productUnitId,
                isExpanded: true,
                decoration: InputDecoration(
                  labelText: context.l10n.text('Product unit *'),
                ),
                items: widget.productUnits
                    .map(
                      (item) => DropdownMenuItem(
                        value: item.id,
                        child: Text(_productUnitLabel(item)),
                      ),
                    )
                    .toList(growable: false),
                onChanged: _isEditing
                    ? null
                    : (value) => setState(() => _productUnitId = value),
                validator: (value) => value == null
                    ? context.l10n.text('Select a product unit.')
                    : null,
              ),
              const SizedBox(height: 12),
              TextFormField(
                controller: _sellPrice,
                keyboardType: TextInputType.number,
                decoration: InputDecoration(
                  labelText: context.l10n.text('Sell price *'),
                  helperText: context.l10n.text(
                    'Enter the amount in the application minor monetary unit.',
                  ),
                ),
                validator: (value) {
                  final price = int.tryParse(value?.trim() ?? '');
                  return price == null || price < 0
                      ? context.l10n.text(
                          'Enter a non-negative whole-number price.',
                        )
                      : null;
                },
              ),
              const SizedBox(height: 12),
              ListTile(
                contentPadding: EdgeInsets.zero,
                title: Text(context.l10n.text('Effective date *')),
                subtitle: Text(_effectiveDate.toLocal().toString()),
                trailing: const Icon(Icons.calendar_today_outlined),
                onTap: _pickEffectiveDate,
              ),
              ListTile(
                contentPadding: EdgeInsets.zero,
                title: Text(context.l10n.text('End date')),
                subtitle: Text(
                  _endDate == null
                      ? context.l10n.text('Open-ended')
                      : _endDate!.toLocal().toString(),
                ),
                trailing: Wrap(
                  spacing: 4,
                  children: [
                    if (_endDate != null)
                      IconButton(
                        tooltip: context.l10n.text('Clear'),
                        onPressed: () => setState(() => _endDate = null),
                        icon: const Icon(Icons.clear),
                      ),
                    IconButton(
                      tooltip: context.l10n.text('Select date'),
                      onPressed: _pickEndDate,
                      icon: const Icon(Icons.calendar_today_outlined),
                    ),
                  ],
                ),
              ),
            ],
          ),
        ),
      ),
    ),
    actions: [
      TextButton(
        onPressed: () => Navigator.pop(context),
        child: Text(context.l10n.text('Cancel')),
      ),
      FilledButton(
        onPressed: () {
          if (!(_formKey.currentState?.validate() ?? false)) return;
          final draft = ProductPriceDraft(
            productUnitId: _productUnitId!,
            sellPrice: int.parse(_sellPrice.text.trim()),
            effectiveDate: _effectiveDate,
            endDate: _endDate,
          ).normalized();
          Navigator.pop(context, draft);
        },
        child: Text(context.l10n.text('Save offline')),
      ),
    ],
  );
}
