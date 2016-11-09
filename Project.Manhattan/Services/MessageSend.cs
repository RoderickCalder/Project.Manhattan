using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;
using Project.Manhattan1.Models;
using Project.Manhattan1.Rest;

namespace Project.Manhattan1.Services
{

    public class MessageSend : IMessageSend
    {
        public bool SendMessages(MessageModel messageModel)
        {
            var rest = new RestClient();

            return rest.sendMessage(SerializeModel(messageModel));
        }

        public string SerializeModel(MessageModel messageModel)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            return jss.Serialize(messageModel);
        }

    }
}