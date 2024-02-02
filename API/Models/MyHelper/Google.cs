using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace API.Models.MyHelper
{
    public class Google
    {
        public Boolean success { get; set; }
        public string hostname { get; set; }
        public static bool CheckGoogle(string SecretKey, string Token, int flagDevCoQuan = 0)
        {

            bool flag = true;

            if (flagDevCoQuan == 0)
            {
                string link = "https://www.google.com/recaptcha/api/siteverify?secret=" + SecretKey + "&response=" + Token;

                var options = new RestClientOptions(link)
                {
                    ThrowOnAnyError = true,
                };
                var client = new RestClient(options);
                var request = new RestRequest(link);
                var response = client.Get(request);

                Google google = JsonConvert.DeserializeObject<Google>(response.Content);

                if (google.success == true)
                {
                    flag = true;
                }

            }
            else
            {
                flag = true;
            }
            return flag;

        }
    }
}
