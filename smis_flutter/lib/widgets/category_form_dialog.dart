import 'package:flutter/material.dart';

import '../models/category.dart';
import '../l10n/app_localizations.dart';

class CategoryFormDialog extends StatefulWidget {
  const CategoryFormDialog({super.key, this.category});

  final Category? category;

  @override
  State<CategoryFormDialog> createState() => _CategoryFormDialogState();
}

class _CategoryFormDialogState extends State<CategoryFormDialog> {
  final _formKey = GlobalKey<FormState>();

  late final TextEditingController _englishName;
  late final TextEditingController _dariName;
  late final TextEditingController _code;
  late final TextEditingController _description;
  late bool _isActive;

  @override
  void initState() {
    super.initState();
    _englishName = TextEditingController(text: widget.category?.englishName);
    _dariName = TextEditingController(text: widget.category?.dariName);
    _code = TextEditingController(text: widget.category?.code);
    _description = TextEditingController(text: widget.category?.description);
    _isActive = widget.category?.isActive ?? true;
  }

  @override
  void dispose() {
    _englishName.dispose();
    _dariName.dispose();
    _code.dispose();
    _description.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) => AlertDialog(
    title: Text(
      context.l10n.text(
        widget.category == null ? 'New category' : 'Edit category',
      ),
    ),
    content: SizedBox(
      width: 480,
      child: Form(
        key: _formKey,
        child: SingleChildScrollView(
          child: Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              TextFormField(
                controller: _englishName,
                autofocus: true,
                maxLength: 200,
                decoration: InputDecoration(
                  labelText: context.l10n.text('English name *'),
                ),
                validator: (value) => value == null || value.trim().isEmpty
                    ? context.l10n.text('English name is required.')
                    : null,
              ),
              const SizedBox(height: 12),
              TextFormField(
                controller: _dariName,
                maxLength: 200,
                textDirection: TextDirection.rtl,
                decoration: InputDecoration(
                  labelText: context.l10n.text('Dari name'),
                ),
              ),
              const SizedBox(height: 12),
              TextFormField(
                controller: _code,
                maxLength: 50,
                decoration: InputDecoration(
                  labelText: context.l10n.text('Code'),
                ),
              ),
              const SizedBox(height: 12),
              TextFormField(
                controller: _description,
                maxLength: 500,
                minLines: 2,
                maxLines: 4,
                decoration: InputDecoration(
                  labelText: context.l10n.text('Description'),
                ),
              ),
              SwitchListTile.adaptive(
                contentPadding: EdgeInsets.zero,
                title: Text(context.l10n.text('Active')),
                value: _isActive,
                onChanged: (value) => setState(() => _isActive = value),
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
          if (!_formKey.currentState!.validate()) return;

          Navigator.pop(
            context,
            CategoryDraft(
              name: _englishName.text,
              dariName: _dariName.text,
              code: _code.text,
              description: _description.text,
              isActive: _isActive,
            ),
          );
        },
        child: Text(context.l10n.text('Save offline')),
      ),
    ],
  );
}
