using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PocFreedom
{
    public class Client
    {
        public UserInfo info = null;
        private int id = 0;
        public Dictionary<int,SessionRequest> requests = new Dictionary<int, SessionRequest>();
        public Client(UserInfo info)
        {
            this.info = info;
        }

        public void AddSessionRequest(SessionRequest req)
        {
            requests[id++] = req;
        }

        public void RemoveSessionRequest(int id)
        {
            if (requests.ContainsKey(id))
                requests.Remove(id);
        }
    }
}