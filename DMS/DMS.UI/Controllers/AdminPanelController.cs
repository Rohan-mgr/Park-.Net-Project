using DMS.DAL.DatabaseContext;
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
        MainEntities db = new MainEntities();
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
        public ActionResult Gallery()
        {
            return View();
        }
    }
}