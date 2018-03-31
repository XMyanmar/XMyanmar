using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace XMyanmarAPI.Model.Request
{
    [DataContract]
    public class AuthenticationInfo
    {
        [DataMember(Order = 1)]
        public string UserID { get; set; }

        [DataMember(Order = 2)]
        public string Password { get; set; }
    }
}