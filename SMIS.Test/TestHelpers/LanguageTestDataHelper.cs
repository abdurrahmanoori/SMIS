using System.Net.Http.Json;
using SMIS.Application.DTO.Localization;
using SMIS.Test.TestDataBuilders;

namespace SMIS.Test.TestHelpers
{
    public class LanguageTestDataHelper
    {
        private readonly HttpClient _httpClient;

        public LanguageTestDataHelper(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task GetOrCreateDependencies()
        {
            // Language doesn't have dependencies, so nothing to create here
        }

        public LanguageFixtureBuilder CreateLanguageBuilder()
        {
            return new LanguageFixtureBuilder();
        }
    }
}