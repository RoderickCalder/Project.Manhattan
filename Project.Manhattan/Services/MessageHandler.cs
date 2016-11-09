using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using Newtonsoft.Json;
using Project.Manhattan1.Models;

namespace Project.Manhattan1.Services
{
    public class MessageHandler : IMessageHandler
    {
        public bool MessageSend(MessageModel messageModel)
        {
            var messageSend = new MessageSend();
            return messageSend.SendMessages(messageModel);
        }

        public MessageModel MessageGet(DateTime dateTime)
        {
            var message = new MessageModel();
            return message;
        }

        public MessageModel DataManip(MessageModel messageModel)
        {
            return messageModel;
        }

        public bool Handling(MessageModel message)
        {
            return true;
        }
    }
}