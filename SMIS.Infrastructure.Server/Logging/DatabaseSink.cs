using Serilog.Events;
using Serilog.Sinks.PeriodicBatching;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using SMIS.Application.Repositories;

namespace SMIS.Infrastructure.Server.Logging
{
    public class DatabaseSink : IBatchedLogEventSink
    {
        private readonly IServiceProvider _serviceProvider;

        public DatabaseSink(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task EmitBatchAsync(IEnumerable<LogEvent> batch)
        {
            using var scope = _serviceProvider.CreateScope();
            var logRepository = scope.ServiceProvider.GetRequiredService<ILogRepository>();

            var logs = batch.Select(MapLogEvent).ToList();
            await logRepository.SaveLogsAsync(logs);
        }

        public Task OnEmptyBatchAsync() => Task.CompletedTask;

        private static AppLog MapLogEvent(LogEvent logEvent)
        {
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