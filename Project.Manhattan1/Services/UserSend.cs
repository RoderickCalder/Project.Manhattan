using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using Project.Manhattan1.Models;
using Project.Manhattan1.Rest;

namespace Project.Manhattan1.Services
{
    public class UserSend
    {
        public bool SendUsers(UserModel userModel)
        {
            var rest = new RestClient();

            return rest.sendUser(SerializeModel(userModel));
        }

        public string SerializeModel(UserModel userModel )
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            return jss.Serialize(userModel);
        }
    }
}