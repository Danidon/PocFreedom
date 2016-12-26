using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace PocFreedom.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(string username,string password)
        {
            if(Main.registerUser(username, password, /*Request.UserHostAddress*/"127.0.0.1"))
                return View("Session");
            return View("Index");
        }

        public ContentResult GetConnectedUsers()
        {
            
            return Content(new JavaScriptSerializer().Serialize(Main.getConnectedUsers()));
        }
    }


}