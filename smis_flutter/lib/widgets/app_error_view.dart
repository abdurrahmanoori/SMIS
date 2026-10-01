import 'package:flutter/material.dart';

import '../data/data_exception.dart';
import '../l10n/app_localizations.dart';

class AppErrorView extends StatelessWidget {
  const AppErrorView({
    super.key,
    required this.error,
    this.stackTrace,
    this.onRetry,
    this.title,
  });

  final Object error;
  final StackTrace? stackTrace;
  final VoidCallback? onRetry;
  final String? title;

  @override
  Widget build(BuildContext context) {
    final colors = Theme.of(context).colorScheme;
    final messages = AppErrorPresentation.messages(context, error);
    final referenceId = AppErrorPresentation.referenceId(error);
    final showDevelopmentDetails = AppErrorPresentation.showDevelopmentDetails;

    return Center(
      child: Padding(
        padding: const EdgeInsets.all(24),
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            Icon(_iconFor(error), size: 48, color: colors.error),
            const SizedBox(height: 16),
            Text(
              title ?? context.l10n.text('Something went wrong'),
              style: Theme.of(context).textTheme.titleLarge,
              textAlign: TextAlign.center,
            ),
            const SizedBox(height: 8),
            for (var index = 0; index < messages.length; index++) ...[
              if (index > 0) const SizedBox(height: 6),
              Text(
                messages[index],
                textAlign: TextAlign.center,
                style: Theme.of(context).textTheme.bodyMedium,
              ),
            ],
            if (!showDevelopmentDetails && referenceId != null) ...[
              const SizedBox(height: 8),
              Text(
                '${context.l10n.text('Reference')}: $referenceId',
                textAlign: TextAlign.center,
                style: Theme.of(context).textTheme.bodySmall,
              ),
            ],
            if (showDevelopmentDetails) ...[
              const SizedBox(height: 24),
              _DevelopmentErrorDetails(error: error, stackTrace: stackTrace),
            ],
            if (onRetry != null) ...[
              const SizedBox(height: 24),
              FilledButton.tonalIcon(
                onPressed: onRetry,
                icon: const Icon(Icons.refresh),
                label: Text(context.l10n.text('Try again')),
              ),
            ],
          ],
        ),
      ),
    );
  }

  IconData _iconFor(Object error) {
    if (error is AuthenticationException || error is AuthorizationException) {
      return Icons.lock_outline;
    }
    if (error is RemoteTransientException) return Icons.cloud_off_outlined;
    return Icons.error_outline;
  }
}

class _DevelopmentErrorDetails extends StatefulWidget {
  const _DevelopmentErrorDetails({required this.error, this.stackTrace});

  final Object error;
  final StackTrace? stackTrace;

  @override
  State<_DevelopmentErrorDetails> createState() =>
      _DevelopmentErrorDetailsState();
}

class _DevelopmentErrorDetailsState extends State<_DevelopmentErrorDetails> {
  bool _expanded = false;

  @override
  Widget build(BuildContext context) {
    final colors = Theme.of(context).colorScheme;
    return Card(
      color: colors.surfaceContainerHighest.withValues(alpha: 0.3),
      child: ExpansionPanelList(
        elevation: 0,
        expandedHeaderPadding: EdgeInsets.zero,
        expansionCallback: (_, isExpanded) =>
            setState(() => _expanded = isExpanded),
        children: [
          ExpansionPanel(
            backgroundColor: Colors.transparent,
            headerBuilder: (context, isExpanded) => ListTile(
              dense: true,
              title: Text(
                context.l10n.text('Development details'),
                style: const TextStyle(fontWeight: FontWeight.bold),
              ),
              leading: const Icon(Icons.bug_report_outlined),
            ),
            body: Padding(
              padding: const EdgeInsets.fromLTRB(16, 0, 16, 16),
              child: Container(
                width: double.infinity,
                constraints: const BoxConstraints(maxHeight: 360),
                padding: const EdgeInsets.all(12),
                decoration: BoxDecoration(
                  color: Colors.black87,
                  borderRadius: BorderRadius.circular(6),
                ),
                child: SingleChildScrollView(
                  child: SelectableText(
                    AppErrorPresentation.developmentDetails(
                      widget.error,
                      widget.stackTrace,
                    ),
                    style: const TextStyle(
                      color: Colors.greenAccent,
                      fontFamily: 'monospace',
                      fontSize: 10,
                    ),
                  ),
                ),
              ),
            ),
            isExpanded: _expanded,
          ),
        ],
      ),
    );
  }
}
