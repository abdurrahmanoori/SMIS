class ComponentPermission {
  const ComponentPermission({
    required this.componentKey,
    required this.canView,
    required this.canRead,
    required this.canCreate,
    required this.canUpdate,
    required this.canDelete,
  });

  final String componentKey;
  final bool canView;
  final bool canRead;
  final bool canCreate;
  final bool canUpdate;
  final bool canDelete;

  factory ComponentPermission.fromJson(Map<String, dynamic> json) =>
      ComponentPermission(
        componentKey: (json['componentKey'] ?? json['ComponentKey'] ?? '')
            .toString(),
        canView: json['canView'] ?? json['CanView'] ?? false,
        canRead: json['canRead'] ?? json['CanRead'] ?? false,
        canCreate: json['canCreate'] ?? json['CanCreate'] ?? false,
        canUpdate: json['canUpdate'] ?? json['CanUpdate'] ?? false,
        canDelete: json['canDelete'] ?? json['CanDelete'] ?? false,
      );

  Map<String, dynamic> toJson() => {
    'componentKey': componentKey,
    'canView': canView,
    'canRead': canRead,
    'canCreate': canCreate,
    'canUpdate': canUpdate,
    'canDelete': canDelete,
  };
}
