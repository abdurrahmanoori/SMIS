using System.Text.Json;

namespace SMIS.Application.Common.Exceptions
{
    public class ExceptionLog
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Message { get; set; } = string.Empty;
        public string? StackTrace { get; set; }
        public string? Source { get; set; }
        public InnerExceptionLog? InnerException { get; set; }

        public static ExceptionLog CreateLog(Exception exception)
        {
            return new ExceptionLog
            {
                Message = exception.Message,
                StackTrace = exception.StackTrace,
                Source = exception.Source,
                InnerException = exception.InnerException != null 
                    ? new InnerExceptionLog
                    {
                        Message = exception.InnerException.Message,
                        StackTrace = exception.InnerException.StackTrace
                    } 
                    : null
            };
        }

        public string ToJson() => JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
    }

    public class InnerExceptionLog
    {
        public string Message { get; set; } = string.Empty;
        public string? StackTrace { get; set; }
    }
}