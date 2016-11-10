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

        public List<MessageModel> MessageGet()
        {
            var GetRequest = new MessageGet();
            List<MessageModel> messages = GetRequest.GetMessages();
            return messages;
        }

        public MessageModel DataManip(MessageModel messageModel)
        {
            return messageModel;
        }

        public List<UserModel> GetUser()
        {
            var GetRequest = new UserGet();
            List<UserModel> users = GetRequest.GetUsers();
            return users;
        } 

    }
}