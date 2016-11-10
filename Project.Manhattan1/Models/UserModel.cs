using System;
using System.Runtime.Serialization;

namespace Project.Manhattan1.Models
{
    public class UserModel 
    {
        [IgnoreDataMember]
        public string Id { get; set; }

        public string Name { get; set; }
    }
}