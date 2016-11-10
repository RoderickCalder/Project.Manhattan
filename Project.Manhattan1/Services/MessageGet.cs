using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Project.Manhattan1.Models;
using Project.Manhattan1.Rest;

namespace Project.Manhattan1.Services
{
    public class MessageGet
    {
        public List<MessageModel> GetMessages()
        {
            var rest = new RestClient();
            var deserialized = DeserializeModel(rest.getMessage());
            return deserialized;
        }

        public List<MessageModel> DeserializeModel(string message)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            var result = jss.Deserialize<Dictionary<string, MessageModel>>(message);
            return result.Values.ToList();
          
        }
    }
}