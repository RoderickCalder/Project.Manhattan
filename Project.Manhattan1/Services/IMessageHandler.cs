using System;
using System.Collections.Generic;
using Project.Manhattan1.Models;

namespace Project.Manhattan1.Services
{
    public interface IMessageHandler
    {
        bool MessageSend(MessageModel messageModel);
        List<MessageModel> MessageGet();
        MessageModel DataManip(MessageModel messageModel);
    }
}