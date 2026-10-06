class ManagedComponent {
  const ManagedComponent({
    required this.id,
    required this.key,
    required this.name,
    required this.displayOrder,
    required this.isActive,
  });
  final String id;
  final String key;
  final String name;
  final int displayOrder;
  final bool isActive;

  factory ManagedComponent.fromJson(Map<String, dynamic> json) =>
      ManagedComponent(
        id: json['id'] as String,
        key: json['key'] as String,
        name: json['name'] as String,
        displayOrder: json['displayOrder'] as int,
        isActive: json['isActive'] as bool,
      );
}

class PermissionRole {
  const PermissionRole({required this.id, required this.name});
  final String id;
  final String name;
  factory PermissionRole.fromJson(Map<String, dynamic> json) =>
      PermissionRole(id: json['id'] as String, name: json['name'] as String);
}

class ManagedComponentPermission {
  ManagedComponentPermission({required this.componentId, List<bool>? grants})
    : grants = grants ?? List<bool>.filled(5, false);
  final String componentId;
  final List<bool> grants;

  factory ManagedComponentPermission.fromJson(Map<String, dynamic> json) =>
      ManagedComponentPermission(
        componentId: json['componentId'] as String,
        grants: [for (final key in keys) json[key] == true],
      );

  static const keys = [
    'canView',
    'canRead',
    'canCreate',
    'canUpdate',
    'canDelete',
  ];
  Map<String, dynamic> toJson() => {
    'componentId': componentId,
    for (var i = 0; i < keys.length; i++) keys[i]: grants[i],
  };
}

class PermissionCatalog {
  const PermissionCatalog({required this.components, required this.roles});
  final List<ManagedComponent> components;
  final List<PermissionRole> roles;
  factory PermissionCatalog.fromJson(Map<String, dynamic> json) =>
      PermissionCatalog(
        components: (json['components'] as List)
            .map(
              (e) => ManagedComponent.fromJson(
                Map<String, dynamic>.from(e as Map),
              ),
            )
            .toList(),
        roles: (json['roles'] as List)
            .map(
              (e) =>
                  PermissionRole.fromJson(Map<String, dynamic>.from(e as Map)),
            )
            .toList(),
      );
}
