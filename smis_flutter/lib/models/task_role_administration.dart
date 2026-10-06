class ManagedTask {
  const ManagedTask({
    required this.id,
    required this.key,
    required this.name,
    required this.componentId,
    required this.isActive,
    required this.isSystem,
  });
  final String id, key, name, componentId;
  final bool isActive, isSystem;
  factory ManagedTask.fromJson(Map<String, dynamic> json) => ManagedTask(
    id: json['id'] as String,
    key: json['key'] as String,
    name: json['name'] as String,
    componentId: json['componentId'] as String,
    isActive: json['isActive'] == true,
    isSystem: json['isSystem'] == true,
  );
}

class ManagedRole {
  const ManagedRole({
    required this.id,
    required this.name,
    required this.isSystem,
    required this.userCount,
  });
  final String id, name;
  final bool isSystem;
  final int userCount;
  factory ManagedRole.fromJson(Map<String, dynamic> json) => ManagedRole(
    id: json['id'] as String,
    name: json['name'] as String,
    isSystem: json['isSystem'] == true,
    userCount: json['userCount'] as int,
  );
}
