//using System;
//using System.Net;
//using System.Net.Http.Json;
//using SMIS.Application.DTO.Localization;
//using SMIS.Test.TestInfrastructure;
//using Xunit;
//using Xunit.Abstractions;

//namespace SMIS.Test.Utilities
//{
//    public class ExceptionFormattingExample : IClassFixture<CustomWebApplicationFactory>, IDisposable
//    {
//        private readonly CustomWebApplicationFactory _factory;
//        private readonly HttpClient _client;
//        private readonly ITestOutputHelper _output;

//        public ExceptionFormattingExample(CustomWebApplicationFactory factory, ITestOutputHelper output)
//        {

//            _factory = factory;
//            _client = factory.CreateClient();
//            _output = output;
//        }

//        [Fact]
//        public async Task ExampleOfFormattedExceptionHandling()
//        {
//            try
//            {
//                // Example API call that might fail
//                var dto = new LanguageCreateDto { Name = "Test Language", Code = "TL", IsActive = true };
//                var response = await _client.PostAsJsonAsync("/api/language", dto);
                
//                if (!response.IsSuccessStatusCode)
//                {
//                    var errorContent = await response.Content.ReadAsStringAsync();
                    
//                    // Use our centralized formatter to format the error
//                    var formattedError = ExceptionFormatter.FormatApiResponseError(errorContent);
                    
//                    // Output the nicely formatted error
//                    _output.WriteLine("API Call Failed:");
//                    _output.WriteLine(formattedError);
                    
//                    // Or throw with formatted message
//                    throw new HttpRequestException($"API request failed with status {response.StatusCode}\n{formattedError}");
//                }
                
//                // Process successful response
//                var result = await response.Content.ReadFromJsonAsync<LanguageDto>();
//                _output.WriteLine($"Successfully created language: {result?.Name}");
//            }
//            catch (HttpRequestException ex)
//            {
//                // Format general exceptions too
//                var formattedException = ExceptionFormatter.FormatException(ex);
//                _output.WriteLine("Exception occurred:");
//                _output.WriteLine(formattedException);
                
//                // Re-throw or handle as needed
//                throw;
//            }
//        }

//        public void Dispose()
//        {
//            _client?.Dispose();
//        }
//    }
//}