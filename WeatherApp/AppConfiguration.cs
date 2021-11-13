using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public static class AppConfiguration
    {
        static private IConfiguration configuration;



        private static void initConfig()
        {
            configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").AddUserSecrets("c437bb8c-40a6-41b3-8ab3-5cb2fb3d706b").Build();
        }
        public static string GetValue(string key)
        {
            if(configuration == null)
            {
                initConfig();
            }
            return configuration.GetValue<string>(key);
        }

        

        
    }
}
