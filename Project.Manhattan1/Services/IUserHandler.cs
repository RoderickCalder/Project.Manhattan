using System.Collections.Generic;
using Project.Manhattan1.Models;

namespace Project.Manhattan1.Services
{
    public interface IUserHandler
    {
        bool UserSend(UserModel userModel);
        List<UserModel> UserGet();
    }
}