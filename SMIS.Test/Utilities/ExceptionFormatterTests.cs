using Xunit;
using SMIS.Test.Utilities;

namespace SMIS.Test.Utilities
{
    public class ExceptionFormatterTests
    {
        [Fact]
        public void FormatApiResponseError_Should_FormatJsonErrorCorrectly()
        {
            var rawError = @"{
  ""Id"": ""5a154108-3c3d-4d7e-8a45-4bab9b1d4024"",
  ""Message"": ""The instance of entity type 'TranslationKey' cannot be tracked because another instance with the key value '{Id: }' is already being tracked. When attaching existing entities, ensure that only one entity instance with a given key value is attached."",
  ""StackTrace"": ""   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.IdentityMap`1.ThrowIdentityConflict(InternalEntityEntry entry)\r\n   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.IdentityMap`1.Add(TKey key, InternalEntityEntry entry, Boolean updateDuplicate)"",
  ""Source"": ""Microsoft.EntityFrameworkCore"",
  ""InnerException"": null
}";

            var formatted = ExceptionFormatter.FormatApiResponseError(rawError);
            
            Assert.Contains("API ERROR RESPONSE", formatted);
            Assert.Contains("Error ID:", formatted);
            Assert.Contains("Message:", formatted);
            Assert.Contains("Stack Trace:", formatted);
            Assert.Contains("Source:", formatted);
        }
        
        [Fact]
        public void FormatException_Should_FormatBasicExceptionCorrectly()
        {
            var exception = new InvalidOperationException("Test exception message");
            var formatted = ExceptionFormatter.FormatException(exception);
            
            Assert.Contains("EXCEPTION DETAILS", formatted);
            Assert.Contains("Exception Type: InvalidOperationException", formatted);
            Assert.Contains("Message: Test exception message", formatted);
        }
        
        [Fact]
        public void ExtractCleanMessage_Should_RemoveEscapeSequences()
        {
            var dirtyMessage = "Message with \\u0027escaped\\u0027 quotes and \\n newlines";
            var cleanMessage = ExceptionFormatter.ExtractCleanMessage(dirtyMessage);
            
            Assert.Contains("'escaped'", cleanMessage);
            Assert.Contains("\n", cleanMessage);
        }
    }
}