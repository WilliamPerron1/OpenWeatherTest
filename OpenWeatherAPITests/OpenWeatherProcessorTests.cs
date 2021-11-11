using OpenWeatherAPI;
using System;
using System.Threading.Tasks;
using Xunit;

namespace OpenWeatherAPITests
{
    public class OpenWeatherProcessorTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public async Task GetOneCallAsync_IfApiKeyEmptyOrNull_ThrowArgumentException(string w)
        {
            OpenWeatherProcessor openWeatherProcessor = OpenWeatherProcessor.Instance;

            openWeatherProcessor.ApiKey = w;

            await Assert.ThrowsAsync<ArgumentException>(openWeatherProcessor.GetOneCallAsync);
        }

        
}
