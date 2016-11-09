using System;
using System.Web.Script.Serialization;
using Project.Manhattan1.Models;
using Project.Manhattan1.Rest;

namespace Project.Manhattan1.Services
{
    public class MessageGet
    {
        public MessageModel GetMessages(DateTime dateTime)
        {
            var rest = new RestClient();
            var deserialized = DeserializeModel(rest.getMessage(dateTime));
            return deserialized;
        }

        public MessageModel DeserializeModel(string message)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            return jss.Deserialize<MessageModel>(message);
        }
    }
}