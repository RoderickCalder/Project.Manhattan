using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using Project.Manhattan1.Models;

namespace Project.Manhattan1.Services
{
    public class MessageSend : IMessageSend
    {
        private const string URL = "https://project-manhattan-65c6a.firebaseio.com/user.json";
        private string urlPramaters = "?auth=9Cg1ESEEm5wer6PpBAkMMc8EsUww1xr3b6amsqRO";
        public bool getMessages()
        {
            HttpClient client  = new HttpClient();
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