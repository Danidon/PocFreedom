using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PocFreedom
{
    public class SessionRequest
    {
        public Client initiator;
        public SessionRequest(Client initiator)
        {
            this.initiator = initiator;
        }
    }
}