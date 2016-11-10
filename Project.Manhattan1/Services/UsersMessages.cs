using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;
using Project.Manhattan1.Models;
using Project.Manhattan1.Rest;

namespace Project.Manhattan1.Services
{
    public class UsersMessages
    {
        public List<MessageModel> getMessages(string id)
        {
            var rest = new RestClient();
            var deserialized = DeserializeModel(rest.getMessage());
            var filterDeserialized = forUser(deserialized, id);
            return filterDeserialized;
        }

        public List<MessageModel> DeserializeModel(string message)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            var result = jss.Deserialize<Dictionary<string, MessageModel>>(message);
            return result.Values.ToList();
        }

        public List<MessageModel> forUser(List<MessageModel> messages, string id)
        {
            var newMessageModel = new List<MessageModel>();
            foreach (var message in messages)
            {
                if (message.UserTo == id)
                {
                    newMessageModel.Add(message);
                }
            }
            return newMessageModel;
        }
    }
}