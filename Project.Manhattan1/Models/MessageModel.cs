using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Manhattan1.Models
{
    public class MessageModel
    {

        public string Message { get; set; }
        public string DateTime { get; set; }
        public string UserFrom { get; set; }
        public string UserTo { get; set; }
    }
    public class MasterModel
    {
        public List<MessageModel> Message { get; set; }
        public List<UserModel> User { get; set; }
    }
}