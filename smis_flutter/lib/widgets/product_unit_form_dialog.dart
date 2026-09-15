import 'package:flutter/material.dart';

import '../l10n/app_localizations.dart';
import '../models/product.dart';
import '../models/product_unit.dart';
import '../models/unit_of_measure.dart';

class ProductUnitFormDialog extends StatefulWidget {
  const ProductUnitFormDialog({
    super.key,
    required this.products,
    required this.units,
    this.productUnit,
  });

  final List<Product> products;
  final List<UnitOfMeasure> units;
  final ProductUnit? productUnit;

  @override
  State<ProductUnitFormDialog> createState() => _ProductUnitFormDialogState();
}

class _ProductUnitFormDialogState extends State<ProductUnitFormDialog> {
  final _formKey = GlobalKey<FormState>();
  late final TextEditingController _conversionFactor;
  String? _productId;
  String? _unitId;

  @override
  void initState() {
    super.initState();
    _productId = widget.productUnit?.productId;
    _unitId = widget.productUnit?.unitOfMeasureId;
    _conversionFactor = TextEditingController(
      text: widget.productUnit?.conversionFactor.toString() ?? '',
    );
  }

  @override
  void dispose() {
    _conversionFactor.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) => AlertDialog(
    title: Text(
      context.l10n.text(
        widget.productUnit == null ? 'New product unit' : 'Edit product unit',
      ),
    ),
    content: SizedBox(
      width: 480,
      child: Form(
        key: _formKey,
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            DropdownButtonFormField<String>(
              value: _productId,
              isExpanded: true,
              decoration: InputDecoration(
                labelText: context.l10n.text('Product *'),
              ),
              items: widget.products
                  .map(
                    (product) => DropdownMenuItem(
                      value: product.id,
                      child: Text(product.name),
                    ),
                  )
                  .toList(growable: false),
              onChanged: (value) => setState(() => _productId = value),
              validator: (value) =>
                  value == null ? context.l10n.text('Select a product.') : null,
            ),
            const SizedBox(height: 12),
            DropdownButtonFormField<String>(
              value: _unitId,
              isExpanded: true,
              decoration: InputDecoration(
                labelText: context.l10n.text('Unit of measurement *'),
              ),
              items: widget.units
                  .map(
                    (unit) => DropdownMenuItem(
                      value: unit.id,
                      child: Text('${unit.name} (${unit.symbol})'),
                    ),
                  )
                  .toList(growable: false),
              onChanged: (value) => setState(() => _unitId = value),
              validator: (value) => value == null
                  ? context.l10n.text('Select a unit of measurement.')
                  : null,
            ),
            const SizedBox(height: 12),
            TextFormField(
              controller: _conversionFactor,
              keyboardType: const TextInputType.numberWithOptions(
                decimal: true,
              ),
              decoration: InputDecoration(
                labelText: context.l10n.text('Conversion factor *'),
                helperText: context.l10n.text(
                  'For example: 12 means one box has 12 pieces.',
                ),
              ),
              validator: (value) {
                final factor = double.tryParse(value?.trim() ?? '');
                return factor == null || factor <= 0
                    ? context.l10n.text('Enter a number greater than zero.')
                    : null;
              },
            ),
          ],
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
          Navigator.pop(
            context,
            ProductUnitDraft(
              productId: _productId!,
              unitOfMeasureId: _unitId!,
              conversionFactor: double.parse(_conversionFactor.text.trim()),
            ),
          );
        },
        child: Text(context.l10n.text('Save offline')),
      ),
    ],
  );
}
