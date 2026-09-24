import 'package:flutter/material.dart';

import '../l10n/app_localizations.dart';
import '../models/product.dart';

class ProductDetailsScreen extends StatelessWidget {
  const ProductDetailsScreen({
    super.key,
    required this.product,
    required this.unitName,
    required this.categoryName,
  });

  final Product product;
  final String unitName;
  final String? categoryName;

  @override
  Widget build(BuildContext context) {
    final imageUrl = product.imageUrl?.trim();
    final hasImageUrl = imageUrl != null && imageUrl.isNotEmpty;

    return Scaffold(
      appBar: AppBar(title: Text(context.l10n.text('Product details'))),
      body: SafeArea(
        child: Center(
          child: ConstrainedBox(
            constraints: const BoxConstraints(maxWidth: 760),
            child: ListView(
              padding: const EdgeInsets.all(16),
              children: [
                _ProductImage(imageUrl: hasImageUrl ? imageUrl : null),
                const SizedBox(height: 16),
                Text(
                  product.name,
                  style: Theme.of(context).textTheme.headlineSmall,
                ),
                const SizedBox(height: 8),
                Align(
                  alignment: AlignmentDirectional.centerStart,
                  child: Chip(
                    avatar: Icon(
                      product.isActive
                          ? Icons.check_circle_outline
                          : Icons.pause_circle_outline,
                      size: 18,
                    ),
                    label: Text(
                      context.l10n.text(
                        product.isActive ? 'Active' : 'Inactive',
                      ),
                    ),
                  ),
                ),
                const SizedBox(height: 16),
                Card(
                  child: Column(
                    children: [
                      _DetailTile(
                        label: context.l10n.text('Base unit'),
                        value: unitName,
                      ),
                      const Divider(height: 1),
                      _DetailTile(
                        label: context.l10n.text('Category'),
                        value: categoryName ?? product.categoryId,
                      ),
                      const Divider(height: 1),
                      _DetailTile(
                        label: context.l10n.text('SKU'),
                        value: _valueOrNotSet(context, product.sku),
                      ),
                      const Divider(height: 1),
                      _DetailTile(
                        label: context.l10n.text('Barcode'),
                        value: _valueOrNotSet(context, product.barcode),
                      ),
                      const Divider(height: 1),
                      _DetailTile(
                        label: context.l10n.text('Image URL'),
                        value: _valueOrNotSet(context, product.imageUrl),
                      ),
                      const Divider(height: 1),
                      _DetailTile(
                        label: context.l10n.text('Description'),
                        value: _valueOrNotSet(context, product.description),
                      ),
                    ],
                  ),
                ),
                const SizedBox(height: 16),
                Card(
                  child: Column(
                    children: [
                      _DetailTile(
                        label: context.l10n.text('Sync status'),
                        value: _syncStatus(context),
                      ),
                      if (product.lastSyncError case final error?) ...[
                        const Divider(height: 1),
                        _DetailTile(
                          label: context.l10n.text('Sync error'),
                          value: error,
                          valueColor: Theme.of(context).colorScheme.error,
                        ),
                      ],
                      const Divider(height: 1),
                      _DetailTile(
                        label: context.l10n.text('Created'),
                        value: _formatDateTime(product.createdAt),
                      ),
                      const Divider(height: 1),
                      _DetailTile(
                        label: context.l10n.text('Updated'),
                        value: _formatDateTime(product.updatedAt),
                      ),
                      const Divider(height: 1),
                      _DetailTile(
                        label: context.l10n.text('Last modified'),
                        value: _formatDateTime(product.lastModifiedUtc),
                      ),
                    ],
                  ),
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }

  String _syncStatus(BuildContext context) => context.l10n.text(
    switch (product.syncStatus) {
      ProductSyncStatus.synced => 'Synced',
      ProductSyncStatus.failed => 'Sync failed',
      _ => 'Waiting to sync',
    },
  );

  static String _valueOrNotSet(BuildContext context, String? value) {
    final normalized = value?.trim();
    return normalized == null || normalized.isEmpty
        ? context.l10n.text('Not set')
        : normalized;
  }

  static String _formatDateTime(DateTime value) {
    final local = value.toLocal();
    String twoDigits(int number) => number.toString().padLeft(2, '0');

    return '${local.year}-${twoDigits(local.month)}-${twoDigits(local.day)} '
        '${twoDigits(local.hour)}:${twoDigits(local.minute)}';
  }
}

class _ProductImage extends StatelessWidget {
  const _ProductImage({required this.imageUrl});

  final String? imageUrl;

  @override
  Widget build(BuildContext context) {
    final uri = imageUrl == null ? null : Uri.tryParse(imageUrl!);
    final isNetworkImage =
        uri != null && (uri.scheme == 'http' || uri.scheme == 'https');

    return Card(
      clipBehavior: Clip.antiAlias,
      child: SizedBox(
        height: 240,
        child: isNetworkImage
            ? Image.network(
                imageUrl!,
                width: double.infinity,
                fit: BoxFit.cover,
                errorBuilder: (_, _, _) => const _ImagePlaceholder(),
              )
            : const _ImagePlaceholder(),
      ),
    );
  }
}

class _ImagePlaceholder extends StatelessWidget {
  const _ImagePlaceholder();

  @override
  Widget build(BuildContext context) => ColoredBox(
    color: Theme.of(context).colorScheme.surfaceContainerHighest,
    child: Center(
      child: Icon(
        Icons.inventory_2_outlined,
        size: 72,
        color: Theme.of(context).colorScheme.outline,
      ),
    ),
  );
}

class _DetailTile extends StatelessWidget {
  const _DetailTile({
    required this.label,
    required this.value,
    this.valueColor,
  });

  final String label;
  final String value;
  final Color? valueColor;

  @override
  Widget build(BuildContext context) => ListTile(
    title: Text(label),
    subtitle: SelectableText(
      value,
      style: valueColor == null ? null : TextStyle(color: valueColor),
    ),
  );
}
