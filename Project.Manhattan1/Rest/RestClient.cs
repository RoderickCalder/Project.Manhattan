using System;
using System.Net.Http;
using System.Runtime.Remoting;
using System.Threading.Tasks;
using Project.Manhattan1.Models;

namespace Project.Manhattan1.Rest
{
    public class RestClient
    {
        private const string URL = "https://project-manhattan-65c6a.firebaseio.com/user.json";
        private string urlPramaters = "?auth=9Cg1ESEEm5wer6PpBAkMMc8EsUww1xr3b6amsqRO";
        public bool getConnection()
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

        public bool sendMessage(string messageModel)
        {
            HttpClient client = new HttpClient();
            HttpContent body = new StringContent(messageModel);
            
            client.BaseAddress = new Uri(URL);

            HttpResponseMessage response = client.PutAsync(urlPramaters, body).Result;

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string getMessage(DateTime dateTime)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(URL);

            return client.GetStringAsync(urlPramaters).ToString();
        }
    }
}