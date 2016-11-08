using System;
using Project.Manhattan1.Models;

namespace Project.Manhattan1.Services
{
    public interface IMessageHandler
    {
        bool MessageSend(MessageModel messageModel);
        MessageModel MessageGet(DateTime dateTime);
        MessageModel DataManip(MessageModel messageModel);
        bool Handling(MessageModel message);
    }
}