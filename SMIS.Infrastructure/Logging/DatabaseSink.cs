using Serilog.Events;
using Serilog.Sinks.PeriodicBatching;
using SMIS.Domain.Entities;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using SMIS.Infrastructure.Repositories;

namespace SMIS.Infrastructure.Logging
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
            var logRepository = scope.ServiceProvider.GetRequiredService<LogRepository>();

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
                Level = logEvent.Level.ToString(),
                Message = logEvent.RenderMessage(),
                Exception = logEvent.Exception?.ToString(),
                Properties = JsonSerializer.Serialize(properties),
                UserId = ExtractUserId(properties),
                CreatedAt = logEvent.Timestamp.UtcDateTime
            };
        }

        private static string? ExtractUserId(Dictionary<string, string> properties)
        {
            if (properties.TryGetValue("UserId", out var userIdStr))
            {
                return userIdStr;
            }
            return null;
        }
    }
}