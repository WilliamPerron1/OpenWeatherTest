using OpenWeatherAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class OpenWeatherService : IWindDataService
    {
        private static OpenWeatherProcessor owp;

        public WindDataModel LastWindData;
        public async Task<WindDataModel> GetDataAsync()
        {
            OWCurrentWeaterModel gg = await owp.GetCurrentWeatherAsync();

            WindDataModel wdm = new WindDataModel();

            wdm.DateTime = DateTime.UnixEpoch.AddSeconds(gg.DateTime);
            wdm.Direction = gg.Wind.Deg;
            wdm.MetrePerSec = gg.Wind.Speed;

            LastWindData = wdm;
            return LastWindData;

        }

        public OpenWeatherService (string apiKey)
        {
            owp = OpenWeatherProcessor.Instance;

            owp.ApiKey = apiKey;
        }
    }
}
