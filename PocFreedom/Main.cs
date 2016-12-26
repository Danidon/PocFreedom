using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PocFreedom
{
    public class Main
    {
        private static Dictionary<string, Client> users = new Dictionary<string, Client>();

        public static bool registerUser(string username,string password, string ip)
        {
            if (username != null && users.ContainsKey(username))
                return false;
            else
                users[username] = new Client(new UserInfo(username, password, ip));
            return true;
        }

        public static Dictionary<string, Client> getConnectedUsers()
        {
            return users;
        }
    }
}