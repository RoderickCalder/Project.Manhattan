using System.Collections.Generic;
using Project.Manhattan1.Models;

namespace Project.Manhattan1.Services
{
    public class UserHandler : IUserHandler
    {
        public bool UserSend(UserModel userModel)
        {
            //var userSend = new MessageSend();
            //return messageSend.SendMessages(messageModel);
            return false;
        }

        public List<UserModel> UserGet()
        {
            //var GetRequest = new UserHandler();
            //List<MessageModel> messages = GetRequest.GetMessages();
            //return messages;
            return null;
        }
    }
}