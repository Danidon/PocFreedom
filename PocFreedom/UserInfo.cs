using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PocFreedom
{
    public class UserInfo
    {
        public string username { get; set; }
        public string password { get; set; }
        public string ip { get; set; }

        public UserInfo(string username, string password, string ip)
        {
            this.username = username;
            this.password = password;
            this.ip = ip;
        }
    }
}