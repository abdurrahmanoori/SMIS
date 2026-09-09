import 'package:dio/dio.dart';
import 'package:flutter/foundation.dart';
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
    final rawMessage = error is AppException
        ? (error as AppException).message
        : error.toString();
    final message = context.l10n.errorMessage(rawMessage);
    
    return Center(
      child: Padding(
        padding: const EdgeInsets.all(24),
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            Icon(
              _iconFor(error),
              size: 48,
              color: colors.error,
            ),
            const SizedBox(height: 16),
            Text(
              title ?? context.l10n.text('Something went wrong'),
              style: Theme.of(context).textTheme.titleLarge,
              textAlign: TextAlign.center,
            ),
            const SizedBox(height: 8),
            Text(
              message,
              textAlign: TextAlign.center,
              style: Theme.of(context).textTheme.bodyMedium,
            ),
            if (kDebugMode) ...[
              const SizedBox(height: 24),
              _DebugErrorDetails(error: error, stackTrace: stackTrace),
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
    if (error is AuthenticationException) return Icons.lock_outline;
    if (error is RemoteTransientException) return Icons.cloud_off_outlined;
    return Icons.error_outline;
  }
}

class _DebugErrorDetails extends StatefulWidget {
  const _DebugErrorDetails({required this.error, this.stackTrace});

  final Object error;
  final StackTrace? stackTrace;

  @override
  State<_DebugErrorDetails> createState() => _DebugErrorDetailsState();
}

class _DebugErrorDetailsState extends State<_DebugErrorDetails> {
  bool _expanded = false;

  DioException? _extractDioException(Object error) {
    if (error is DioException) return error;
    if (error is AppException && error.cause is DioException) {
      return error.cause as DioException;
    }
    return null;
  }

  @override
  Widget build(BuildContext context) {
    final colors = Theme.of(context).colorScheme;
    return Card(
      color: colors.surfaceContainerHighest.withOpacity(0.3),
      child: ExpansionPanelList(
        elevation: 0,
        expandedHeaderPadding: EdgeInsets.zero,
        expansionCallback: (_, isExpanded) => setState(() => _expanded = isExpanded),
        children: [
          ExpansionPanel(
            backgroundColor: Colors.transparent,
            headerBuilder: (context, isExpanded) => ListTile(
              dense: true,
              title: Text(context.l10n.text('Development details'), style: const TextStyle(fontWeight: FontWeight.bold)),
              leading: const Icon(Icons.bug_report_outlined),
            ),
            body: Padding(
              padding: const EdgeInsets.fromLTRB(16, 0, 16, 16),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  _DetailItem(label: context.l10n.text('Type'), value: widget.error.runtimeType.toString()),
                  if (widget.error is AppException) ...[
                    _DetailItem(label: context.l10n.text('Cause type'), value: (widget.error as AppException).cause?.runtimeType.toString() ?? context.l10n.text('None')),
                    if ((widget.error as AppException).cause case final cause?)
                      _DetailItem(label: context.l10n.text('Cause message'), value: cause.toString()),
                  ],
                  if (_extractDioException(widget.error) case final dioError?) ...[
                    const Divider(),
                    Text('${context.l10n.text('Network details')}:', style: const TextStyle(fontWeight: FontWeight.bold, fontSize: 11)),
                    _DetailItem(label: context.l10n.text('Method'), value: dioError.requestOptions.method),
                    _DetailItem(label: context.l10n.text('Path'), value: dioError.requestOptions.path),
                    _DetailItem(label: context.l10n.text('Status'), value: dioError.response?.statusCode?.toString() ?? 'N/A'),
                  ],
                  if (widget.stackTrace != null) ...[
                    const SizedBox(height: 8),
                    Text('${context.l10n.text('Stack trace')}:', style: const TextStyle(fontWeight: FontWeight.bold, fontSize: 12)),
                    const SizedBox(height: 4),
                    Container(
                      padding: const EdgeInsets.all(8),
                      decoration: BoxDecoration(
                        color: Colors.black87,
                        borderRadius: BorderRadius.circular(4),
                      ),
                      constraints: const BoxConstraints(maxHeight: 200),
                      width: double.infinity,
                      child: SingleChildScrollView(
                        child: Text(
                          widget.stackTrace.toString(),
                          style: const TextStyle(
                            color: Colors.greenAccent,
                            fontFamily: 'monospace',
                            fontSize: 10,
                          ),
                        ),
                      ),
                    ),
                  ],
                ],
              ),
            ),
            isExpanded: _expanded,
          ),
        ],
      ),
    );
  }
}

class _DetailItem extends StatelessWidget {
  const _DetailItem({required this.label, required this.value});

  final String label;
  final String value;

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.symmetric(vertical: 2),
      child: RichText(
        text: TextSpan(
          style: Theme.of(context).textTheme.bodySmall,
          children: [
            TextSpan(text: '$label: ', style: const TextStyle(fontWeight: FontWeight.bold)),
            TextSpan(text: value),
          ],
        ),
      ),
    );
  }
}
