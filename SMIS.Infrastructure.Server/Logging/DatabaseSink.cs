using Serilog.Events;
using Serilog.Sinks.PeriodicBatching;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using SMIS.Application.Repositories;

namespace SMIS.Infrastructure.Server.Logging
{
    /// <summary>
    /// Serilog batched sink that persists application log events through the normal
    /// repository layer. A new DI scope is created per batch because sinks are long-lived
    /// while repositories/DbContexts are scoped services.
    /// </summary>
    public class DatabaseSink : IBatchedLogEventSink
    {
        private readonly IServiceProvider _serviceProvider;

        public DatabaseSink(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task EmitBatchAsync(IEnumerable<LogEvent> batch)
        {
            // Never hold a DbContext on the sink itself. Creating a scope here gives each
            // batch an independent scoped repository/DbContext lifetime.
            using var scope = _serviceProvider.CreateScope();
            var logRepository = scope.ServiceProvider.GetRequiredService<ILogRepository>();

            var logs = batch.Select(MapLogEvent).ToList();
            await logRepository.SaveLogsAsync(logs);
        }

        public Task OnEmptyBatchAsync() => Task.CompletedTask;

        private static AppLog MapLogEvent(LogEvent logEvent)
        {
            // Preserve structured Serilog properties as JSON so diagnostics can recover
            // request/user context without adding a database column for every property.
            var properties = logEvent.Properties.ToDictionary(
                kvp => kvp.Key,
                kvp => kvp.Value.ToString()
            );

            return new AppLog
            {
                Name = logEvent.Level.ToString(),
                Level = logEvent.Level.ToString(),
                Message = logEvent.RenderMessage(),
                Exception = logEvent.Exception?.ToString(),
                Properties = JsonSerializer.Serialize(properties),
                UserId = ExtractUserId(logEvent.Properties),
                CreatedAt = DateTimeService.NowLocal
            };
        }

        private static string? ExtractUserId(IReadOnlyDictionary<string, LogEventPropertyValue> properties)
        {
            if (!properties.TryGetValue("UserId", out var userIdValue) ||
                userIdValue is not ScalarValue { Value: string userId } ||
                string.IsNullOrWhiteSpace(userId))
                return null;

            return userId;
        }
    }
}