using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;
using Project.Manhattan1.Models;
using Project.Manhattan1.Rest;

namespace Project.Manhattan1.Services
{
    public class UserGet
    {
        public List<UserModel> GetUsers()
        {
            var rest = new RestClient();
            var deserialized = DeserializeModel(rest.getUsers());
            return deserialized;
        }

        public List<UserModel> DeserializeModel(string user)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            var result = jss.Deserialize<Dictionary<string, UserModel>>(user);

            foreach (KeyValuePair<string, UserModel> kvp in result)
            {
                kvp.Value.Id = kvp.Key;
            }

            return result.Values.ToList();

        }
    }
}