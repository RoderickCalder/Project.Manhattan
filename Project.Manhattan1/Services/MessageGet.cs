using System;
using System.Collections.Generic;
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
            List<MessageModel> ListOfMessages = new List<MessageModel>();
            var result = jss.Deserialize<dynamic>(message);
            foreach (var entry in result.Values)
            {
                ListOfMessages.Add(new MessageModel { DateTime = entry["DateTime"], Message = entry["Message"], User = entry["User"]});
            }
            return ListOfMessages;
        }
    }
}