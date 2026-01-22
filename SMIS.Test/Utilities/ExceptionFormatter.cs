using System.Text;
using System.Text.Json;

namespace SMIS.Test.Utilities
{
    public static class ExceptionFormatter
    {
        /// <summary>
        /// Formats an API response error with clean, readable output
        /// </summary>
        /// <param name="rawErrorResponse">Raw error response from API</param>
        /// <returns>Nicely formatted error string</returns>
        public static string FormatApiResponseError(string rawErrorResponse)
        {
            var sb = new StringBuilder();
            sb.AppendLine("=".PadRight(60, '='));
            sb.AppendLine("API ERROR RESPONSE");
            sb.AppendLine("=".PadRight(60, '='));
            
            try
            {
                // Try to parse as JSON first
                using var doc = JsonDocument.Parse(rawErrorResponse);
                var root = doc.RootElement;
                
                if (root.TryGetProperty("Id", out var idElement))
                {
                    sb.AppendLine($"Error ID: {idElement.GetString() ?? "N/A"}");
                }
                
                if (root.TryGetProperty("Message", out var messageElement))
                {
                    var message = messageElement.GetString() ?? "N/A";
                    message = CleanEscapeSequences(message);
                    sb.AppendLine($"Message: {message}");
                }
                
                if (root.TryGetProperty("StackTrace", out var stackTraceElement))
                {
                    var stackTrace = stackTraceElement.GetString();
                    if (!string.IsNullOrEmpty(stackTrace))
                    {
                        sb.AppendLine("\nStack Trace:");
                        sb.AppendLine("-".PadRight(40, '-'));
                        var cleanStackTrace = CleanEscapeSequences(stackTrace);
                        
                        var lines = cleanStackTrace.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var line in lines)
                        {
                            var trimmedLine = line.Trim();
                            if (!string.IsNullOrEmpty(trimmedLine))
                            {
                                sb.AppendLine($"  {trimmedLine}");
                            }
                        }
                    }
                }
                
                if (root.TryGetProperty("Source", out var sourceElement))
                {
                    sb.AppendLine($"\nSource: {sourceElement.GetString() ?? "N/A"}");
                }
                
                if (root.TryGetProperty("InnerException", out var innerElement) && 
                    innerElement.ValueKind != JsonValueKind.Null)
                {
                    sb.AppendLine("\nInner Exception:");
                    sb.AppendLine("-".PadRight(40, '-'));
                    FormatInnerException(innerElement, sb);
                }
            }
            catch (JsonException)
            {
                // If JSON parsing fails, format as plain text
                sb.AppendLine("Raw Error Response (JSON parsing failed):");
                sb.AppendLine("-".PadRight(40, '-'));
                sb.AppendLine(rawErrorResponse);
            }
            catch (Exception ex)
            {
                sb.AppendLine($"Error processing error response: {ex.Message}");
                sb.AppendLine($"Original response: {rawErrorResponse}");
            }
            
            sb.AppendLine("=".PadRight(60, '='));
            
            return sb.ToString();
        }
        
        /// <summary>
        /// Formats a general exception with clean, readable output
        /// </summary>
        /// <param name="exception">The exception to format</param>
        /// <returns>Nicely formatted exception string</returns>
        public static string FormatException(Exception exception)
        {
            var sb = new StringBuilder();
            sb.AppendLine("=".PadRight(60, '='));
            sb.AppendLine("EXCEPTION DETAILS");
            sb.AppendLine("=".PadRight(60, '='));
            
            sb.AppendLine($"Exception Type: {exception?.GetType().Name ?? "N/A"}");
            sb.AppendLine($"Message: {ExtractCleanMessage(exception?.Message ?? "N/A")}");
            
            if (!string.IsNullOrEmpty(exception?.StackTrace))
            {
                sb.AppendLine("\nStack Trace:");
                sb.AppendLine("-".PadRight(40, '-'));
                var cleanStackTrace = CleanEscapeSequences(exception.StackTrace);
                
                var lines = cleanStackTrace.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var line in lines)
                {
                    var trimmedLine = line.Trim();
                    if (!string.IsNullOrEmpty(trimmedLine))
                    {
                        sb.AppendLine($"  {trimmedLine}");
                    }
                }
            }
            
            if (exception?.InnerException != null)
            {
                sb.AppendLine("\nINNER EXCEPTION:");
                sb.AppendLine("-".PadRight(40, '-'));
                sb.AppendLine(FormatException(exception.InnerException));
            }
            
            sb.AppendLine("=".PadRight(60, '='));
            
            return sb.ToString();
        }
        
        /// <summary>
        /// Formats inner exception from JSON element
        /// </summary>
        private static void FormatInnerException(JsonElement innerElement, StringBuilder sb)
        {
            if (innerElement.TryGetProperty("Message", out var innerMsg))
            {
                var msg = CleanEscapeSequences(innerMsg.GetString() ?? "N/A");
                msg = System.Net.WebUtility.HtmlDecode(msg);
                sb.AppendLine($"  Message: {msg}");
            }
            
            if (innerElement.TryGetProperty("StackTrace", out var innerStack))
            {
                var stackTrace = innerStack.GetString();
                if (!string.IsNullOrEmpty(stackTrace))
                {
                    sb.AppendLine("  Stack Trace:");
                    var cleanStack = CleanEscapeSequences(stackTrace);
                    var lines = cleanStack.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var line in lines)
                    {
                        var trimmedLine = line.Trim();
                        if (!string.IsNullOrEmpty(trimmedLine))
                        {
                            sb.AppendLine($"    {trimmedLine}");
                        }
                    }
                }
            }
        }
        
        /// <summary>
        /// Cleans escape sequences from text
        /// </summary>
        private static string CleanEscapeSequences(string text)
        {
            if (string.IsNullOrEmpty(text)) return text;
            
            return text
                .Replace("\\r\\n", Environment.NewLine)
                .Replace("\\n", Environment.NewLine)
                .Replace("\\r", "")
                .Replace("\\u0027", "'")
                .Replace("\\u0060", "`")
                .Replace("\\\"", "\"");
        }
        
        /// <summary>
        /// Extracts and cleans up a message by removing common escape sequences
        /// </summary>
        /// <param name="message">The raw message to clean</param>
        /// <returns>Cleaned message</returns>
        public static string ExtractCleanMessage(string message)
        {
            return CleanEscapeSequences(message);
        }
    }
}