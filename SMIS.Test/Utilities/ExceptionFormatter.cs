using System.Text;
using System.Text.Json;

namespace SMIS.Test.Utilities;

public static class ExceptionFormatter
{
    private const int SeparatorLength = 60;
    private const int SubSeparatorLength = 40;
    private const string MainSeparator = "=";
    private const string SubSeparator = "-";

    public static string FormatApiResponseError(string rawErrorResponse)
    {
        var sb = new StringBuilder();
        AppendHeader(sb, "API ERROR RESPONSE");
        
        try
        {
            using var doc = JsonDocument.Parse(rawErrorResponse);
            var root = doc.RootElement;
            
            if (root.ValueKind == JsonValueKind.Array)
            {
                FormatValidationErrors(sb, root);
                return sb.ToString();
            }
            
            FormatJsonError(sb, root);
        }
        catch (JsonException)
        {
            FormatPlainTextError(sb, rawErrorResponse);
        }
        catch (Exception ex)
        {
            FormatProcessingError(sb, ex, rawErrorResponse);
        }
        
        AppendFooter(sb);
        return sb.ToString();
    }
    
    public static string FormatException(Exception exception)
    {
        var sb = new StringBuilder();
        AppendHeader(sb, "EXCEPTION DETAILS");
        
        sb.AppendLine($"Exception Type: {exception?.GetType().Name ?? "N/A"}");
        sb.AppendLine($"Message: {ExtractCleanMessage(exception?.Message ?? "N/A")}");
        
        if (!string.IsNullOrEmpty(exception?.StackTrace))
        {
            FormatStackTrace(sb, exception.StackTrace);
        }
        
        if (exception?.InnerException != null)
        {
            sb.AppendLine("\nINNER EXCEPTION:");
            sb.AppendLine(SubSeparator.PadRight(SubSeparatorLength, SubSeparator[0]));
            sb.AppendLine(FormatException(exception.InnerException));
        }
        
        AppendFooter(sb);
        return sb.ToString();
    }
    
    public static string ExtractCleanMessage(string message) => CleanEscapeSequences(message);
    
    private static void AppendHeader(StringBuilder sb, string title)
    {
        sb.AppendLine(MainSeparator.PadRight(SeparatorLength, MainSeparator[0]));
        sb.AppendLine(title);
        sb.AppendLine(MainSeparator.PadRight(SeparatorLength, MainSeparator[0]));
    }
    
    private static void AppendFooter(StringBuilder sb) =>
        sb.AppendLine(MainSeparator.PadRight(SeparatorLength, MainSeparator[0]));
    
    private static void FormatValidationErrors(StringBuilder sb, JsonElement root)
    {
        sb.AppendLine("Validation Errors:");
        sb.AppendLine(SubSeparator.PadRight(SubSeparatorLength, SubSeparator[0]));
        
        foreach (var error in root.EnumerateArray())
        {
            foreach (var property in error.EnumerateObject())
            {
                var value = property.Value.ValueKind == JsonValueKind.String 
                    ? property.Value.GetString() 
                    : property.Value.ToString();
                sb.AppendLine($"  {property.Name}: {value}");
            }
            sb.AppendLine();
        }
        
        AppendFooter(sb);
    }
    
    private static void FormatJsonError(StringBuilder sb, JsonElement root)
    {
        AppendPropertyIfExists(sb, root, "Id", "Error ID");
        AppendPropertyIfExists(sb, root, "Message", "Message", CleanEscapeSequences);
        
        if (root.TryGetProperty("StackTrace", out var stackTraceElement))
        {
            var stackTrace = stackTraceElement.GetString();
            if (!string.IsNullOrEmpty(stackTrace))
            {
                FormatStackTrace(sb, stackTrace);
            }
        }
        
        AppendPropertyIfExists(sb, root, "Source", "Source");
        
        if (root.TryGetProperty("InnerException", out var innerElement) && 
            innerElement.ValueKind != JsonValueKind.Null)
        {
            sb.AppendLine("\nInner Exception:");
            sb.AppendLine(SubSeparator.PadRight(SubSeparatorLength, SubSeparator[0]));
            FormatInnerException(innerElement, sb);
        }
    }
    
    private static void FormatPlainTextError(StringBuilder sb, string rawErrorResponse)
    {
        sb.AppendLine("Raw Error Response (JSON parsing failed):");
        sb.AppendLine(SubSeparator.PadRight(SubSeparatorLength, SubSeparator[0]));
        sb.AppendLine(rawErrorResponse);
    }
    
    private static void FormatProcessingError(StringBuilder sb, Exception ex, string rawErrorResponse)
    {
        sb.AppendLine($"Error processing error response: {ex.Message}");
        sb.AppendLine($"Original response: {rawErrorResponse}");
    }
    
    private static void AppendPropertyIfExists(StringBuilder sb, JsonElement root, string propertyName, string displayName, Func<string, string>? transformer = null)
    {
        if (root.TryGetProperty(propertyName, out var element))
        {
            var value = element.GetString() ?? "N/A";
            if (transformer != null)
                value = transformer(value);
            sb.AppendLine($"{displayName}: {value}");
        }
    }
    
    private static void FormatStackTrace(StringBuilder sb, string stackTrace)
    {
        sb.AppendLine("\nStack Trace:");
        sb.AppendLine(SubSeparator.PadRight(SubSeparatorLength, SubSeparator[0]));
        
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
}