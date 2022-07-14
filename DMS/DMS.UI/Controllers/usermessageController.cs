using DMS.DAL.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DMS.Controllers
{
    public class usermessageController : Controller
    {
        // GET: usermessage
        MainEntities db = new MainEntities();
        public ActionResult Index()
        {
            return View();
        }
        
    }
}