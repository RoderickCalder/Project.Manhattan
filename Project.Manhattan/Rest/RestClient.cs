using System;
using System.Net.Http;

namespace Project.Manhattan1.Rest
{
    public class RestClient
    {
        private const string URL = "https://project-manhattan-65c6a.firebaseio.com/user.json";
        private string urlPramaters = "?auth=9Cg1ESEEm5wer6PpBAkMMc8EsUww1xr3b6amsqRO";
        public bool getMessages()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            HttpResponseMessage response = client.GetAsync(urlPramaters).Result;

            if (response.IsSuccessStatusCode)
            {
                String tmp = "YAY";
                return true;
            }
            else
            {
                String mtp = "boo";
                return false;
            }

        }
    }
}