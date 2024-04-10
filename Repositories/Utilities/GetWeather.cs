using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Repositories.Utilities
{
    public class GetWeather
    {
        public string[] getWeatherData(string location)
        {
            var client = new RestClient($"https://wttr.in/{WebUtility.UrlEncode(location)}?format=%C+%t+%w+%h");
            var request = new RestRequest();
            request.AddParameter("method", "GET");
            var response = client.Execute(request);
            if (response.IsSuccessful)
            {
                string[] weatherParameters = Regex.Split(response.Content, " ");
                return weatherParameters;   
            } else
            {
                return [];
            }
        }
    }
}
