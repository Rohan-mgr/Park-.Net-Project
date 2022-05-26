using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DMS.Controllers
{
    //[AllowAnonymous]
    public class AdminPanelController : Controller
    {
        // GET: AdminPanel
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult index2()
        {
            return View();
        }
        public ActionResult Chart()
        {
            return View();
        }
    }
}