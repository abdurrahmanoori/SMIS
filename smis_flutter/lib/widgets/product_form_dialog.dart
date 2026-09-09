import 'package:flutter/material.dart';

import '../models/category.dart';
import '../models/product.dart';
import '../models/unit_of_measure.dart';
import '../l10n/app_localizations.dart';

class ProductFormDialog extends StatefulWidget {
  const ProductFormDialog({
    super.key,
    required this.units,
    required this.categories,
    this.product,
  });
  final List<UnitOfMeasure> units;
  final List<Category> categories;
  final Product? product;

  @override
  State<ProductFormDialog> createState() => _ProductFormDialogState();
}

class _ProductFormDialogState extends State<ProductFormDialog> {
  final _formKey = GlobalKey<FormState>();
  late final TextEditingController _name;
  late final TextEditingController _sku;
  late final TextEditingController _description;
  late final TextEditingController _barcode;
  late final TextEditingController _imageUrl;
  late String? _baseUnitId;
  late String? _categoryId;
  late bool _isActive;

  @override
  void initState() {
    super.initState();
    _name = TextEditingController(text: widget.product?.name);
    _sku = TextEditingController(text: widget.product?.sku);
    _description = TextEditingController(text: widget.product?.description);
    _barcode = TextEditingController(text: widget.product?.barcode);
    _imageUrl = TextEditingController(text: widget.product?.imageUrl);
    _baseUnitId = _availableUnit(widget.product?.baseUnitId);
    _categoryId = _availableCategory(widget.product?.categoryId);
    _isActive = widget.product?.isActive ?? true;
  }

  String? _availableUnit(String? id) => widget.units.any((unit) => unit.id == id) ? id : null;
  String? _availableCategory(String? id) => widget.categories.any((category) => category.id == id) ? id : null;

  @override
  void dispose() {
    _name.dispose(); _sku.dispose(); _description.dispose(); _barcode.dispose(); _imageUrl.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) => AlertDialog(
    title: Text(context.l10n.text(widget.product == null ? 'New product' : 'Edit product')),
    content: SizedBox(
      width: 520,
      child: Form(
        key: _formKey,
        child: SingleChildScrollView(
          child: Column(mainAxisSize: MainAxisSize.min, children: [
            TextFormField(
              controller: _name, autofocus: true, maxLength: 200,
              decoration: InputDecoration(labelText: context.l10n.text('Name *')),
              validator: (value) => value == null || value.trim().isEmpty ? context.l10n.text('Name is required.') : null,
            ),
            const SizedBox(height: 12),
            DropdownButtonFormField<String>(
              value: _baseUnitId,
              isExpanded: true,
              decoration: InputDecoration(labelText: context.l10n.text('Base unit *')),
              items: widget.units.map((unit) => DropdownMenuItem(value: unit.id, child: Text('${unit.name} (${unit.symbol})'))).toList(growable: false),
              onChanged: (value) => setState(() => _baseUnitId = value),
              validator: (value) => value == null ? context.l10n.text('Select a base unit.') : null,
            ),
            const SizedBox(height: 12),
            DropdownButtonFormField<String>(
              value: _categoryId,
              isExpanded: true,
              decoration: InputDecoration(labelText: context.l10n.text('Category')),
              items: [DropdownMenuItem<String>(value: '', child: Text(context.l10n.text('No category'))), ...widget.categories.map((category) => DropdownMenuItem(value: category.id, child: Text(category.name)))],
              onChanged: (value) => setState(() => _categoryId = value?.isEmpty ?? true ? null : value),
            ),
            const SizedBox(height: 12),
            TextFormField(controller: _sku, maxLength: 100, decoration: InputDecoration(labelText: context.l10n.text('SKU'))),
            const SizedBox(height: 12),
            TextFormField(controller: _barcode, maxLength: 100, decoration: InputDecoration(labelText: context.l10n.text('Barcode'))),
            const SizedBox(height: 12),
            TextFormField(controller: _imageUrl, maxLength: 500, keyboardType: TextInputType.url, decoration: InputDecoration(labelText: context.l10n.text('Image URL'))),
            const SizedBox(height: 12),
            TextFormField(controller: _description, maxLength: 500, minLines: 2, maxLines: 4, decoration: InputDecoration(labelText: context.l10n.text('Description'))),
            SwitchListTile.adaptive(contentPadding: EdgeInsets.zero, title: Text(context.l10n.text('Active')), value: _isActive, onChanged: (value) => setState(() => _isActive = value)),
          ]),
        ),
      ),
    ),
    actions: [
      TextButton(onPressed: () => Navigator.pop(context), child: Text(context.l10n.text('Cancel'))),
      FilledButton(
        onPressed: () {
          if (!(_formKey.currentState?.validate() ?? false)) return;
          Navigator.pop(context, ProductDraft(
            name: _name.text, baseUnitId: _baseUnitId!, categoryId: _categoryId,
            sku: _sku.text, description: _description.text, isActive: _isActive,
            barcode: _barcode.text, imageUrl: _imageUrl.text,
          ));
        },
        child: Text(context.l10n.text('Save offline')),
      ),
    ],
  );
}
