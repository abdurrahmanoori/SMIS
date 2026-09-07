import 'package:flutter/material.dart';

import '../models/unit_of_measure.dart';

class UnitOfMeasureFormDialog extends StatefulWidget {
  const UnitOfMeasureFormDialog({super.key, this.unit});

  final UnitOfMeasure? unit;

  @override
  State<UnitOfMeasureFormDialog> createState() =>
      _UnitOfMeasureFormDialogState();
}

class _UnitOfMeasureFormDialogState extends State<UnitOfMeasureFormDialog> {
  final _formKey = GlobalKey<FormState>();
  late final TextEditingController _name;
  late final TextEditingController _symbol;
  late final TextEditingController _description;

  @override
  void initState() {
    super.initState();
    _name = TextEditingController(text: widget.unit?.name);
    _symbol = TextEditingController(text: widget.unit?.symbol);
    _description = TextEditingController(text: widget.unit?.description);
  }

  @override
  void dispose() {
    _name.dispose();
    _symbol.dispose();
    _description.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) => AlertDialog(
    title: Text(widget.unit == null ? 'New unit of measurement' : 'Edit unit of measurement'),
    content: SizedBox(
      width: 480,
      child: Form(
        key: _formKey,
        child: SingleChildScrollView(
          child: Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              TextFormField(
                controller: _name,
                autofocus: true,
                maxLength: 100,
                decoration: const InputDecoration(labelText: 'Name *'),
                validator: (value) => value == null || value.trim().isEmpty
                    ? 'Name is required.'
                    : null,
              ),
              const SizedBox(height: 12),
              TextFormField(
                controller: _symbol,
                maxLength: 20,
                decoration: const InputDecoration(
                  labelText: 'Symbol *',
                  hintText: 'Example: kg, pcs, L',
                ),
                validator: (value) => value == null || value.trim().isEmpty
                    ? 'Symbol is required.'
                    : null,
              ),
              const SizedBox(height: 12),
              TextFormField(
                controller: _description,
                maxLength: 500,
                minLines: 2,
                maxLines: 4,
                decoration: const InputDecoration(labelText: 'Description'),
              ),
            ],
          ),
        ),
      ),
    ),
    actions: [
      TextButton(
        onPressed: () => Navigator.pop(context),
        child: const Text('Cancel'),
      ),
      FilledButton(
        onPressed: () {
          if (!_formKey.currentState!.validate()) return;
          Navigator.pop(
            context,
            UnitOfMeasureDraft(
              name: _name.text,
              symbol: _symbol.text,
              description: _description.text,
            ),
          );
        },
        child: const Text('Save offline'),
      ),
    ],
  );
}
