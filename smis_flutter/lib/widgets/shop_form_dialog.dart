import 'package:flutter/material.dart';

import '../models/shop.dart';

class ShopFormDialog extends StatefulWidget {
  const ShopFormDialog({super.key, this.shop});
  final Shop? shop;
  @override State<ShopFormDialog> createState() => _ShopFormDialogState();
}
class _ShopFormDialogState extends State<ShopFormDialog> {
  final _formKey = GlobalKey<FormState>();
  late final TextEditingController _name; late final TextEditingController _address; late final TextEditingController _phone; late final TextEditingController _email; late final TextEditingController _tax;
  late ShopType _shopType; late bool _isActive;
  @override void initState() { super.initState(); _name = TextEditingController(text: widget.shop?.name); _address = TextEditingController(text: widget.shop?.address); _phone = TextEditingController(text: widget.shop?.phoneNumber); _email = TextEditingController(text: widget.shop?.email); _tax = TextEditingController(text: widget.shop?.taxNumber); _shopType = widget.shop?.shopType ?? ShopType.retailShop; _isActive = widget.shop?.isActive ?? true; }
  @override void dispose() { _name.dispose(); _address.dispose(); _phone.dispose(); _email.dispose(); _tax.dispose(); super.dispose(); }
  @override Widget build(BuildContext context) => AlertDialog(
    title: Text(widget.shop == null ? 'New shop' : 'Edit shop'),
    content: SizedBox(width: 520, child: Form(key: _formKey, child: SingleChildScrollView(child: Column(mainAxisSize: MainAxisSize.min, children: [
      TextFormField(controller: _name, autofocus: true, maxLength: 200, decoration: const InputDecoration(labelText: 'Name *'), validator: (value) => value == null || value.trim().isEmpty ? 'Name is required.' : null),
      const SizedBox(height: 12),
      DropdownButtonFormField<ShopType>(value: _shopType, decoration: const InputDecoration(labelText: 'Shop type *'), items: const [DropdownMenuItem(value: ShopType.retailShop, child: Text('Retail shop')), DropdownMenuItem(value: ShopType.wholesaleShop, child: Text('Wholesale shop'))], onChanged: (value) { if (value != null) setState(() => _shopType = value); }),
      const SizedBox(height: 12), TextFormField(controller: _address, maxLength: 500, minLines: 2, maxLines: 3, decoration: const InputDecoration(labelText: 'Address')),
      const SizedBox(height: 12), TextFormField(controller: _phone, maxLength: 20, keyboardType: TextInputType.phone, decoration: const InputDecoration(labelText: 'Phone number')),
      const SizedBox(height: 12), TextFormField(controller: _email, maxLength: 100, keyboardType: TextInputType.emailAddress, decoration: const InputDecoration(labelText: 'Email')),
      const SizedBox(height: 12), TextFormField(controller: _tax, maxLength: 20, textCapitalization: TextCapitalization.characters, decoration: const InputDecoration(labelText: 'Tax number')),
      SwitchListTile.adaptive(contentPadding: EdgeInsets.zero, title: const Text('Active'), value: _isActive, onChanged: (value) => setState(() => _isActive = value)),
    ])))),
    actions: [TextButton(onPressed: () => Navigator.pop(context), child: const Text('Cancel')), FilledButton(onPressed: () { if (!(_formKey.currentState?.validate() ?? false)) return; Navigator.pop(context, ShopDraft(name: _name.text, shopType: _shopType, address: _address.text, phoneNumber: _phone.text, email: _email.text, taxNumber: _tax.text, isActive: _isActive)); }, child: const Text('Save offline'))],
  );
}
