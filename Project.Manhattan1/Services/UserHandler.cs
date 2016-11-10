using System.Collections.Generic;
using System.Drawing;
using Project.Manhattan1.Models;

namespace Project.Manhattan1.Services
{
    public class UserHandler : IUserHandler
    {
        public bool UserSend(UserModel userModel)
        {
            var userSend = new UserSend();
            return userSend.SendUsers(userModel);
        }

        public List<UserModel> UserGet()
        {
            var GetRequest = new UserHandler();
            List<UserModel> messages = GetRequest.UserGet();
            return messages;
        }

        public List<UserModel> UsersMessages(UserModel userModel)
        {
            var userMessages = new UsersMessages();
            userMessages.getMessages(userModel.Id);

            return null;
        } 
    }
}