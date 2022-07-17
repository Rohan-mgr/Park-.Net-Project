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
            List<User_Message> data = db.User_Message.ToList();
            Session["count"] = db.User_Message.Count();
            //List<Car_Rented> rentCar = db.Car_Rented.ToList();
            Session["rentCount"] = db.Car_Rented.Count();
            Session["sum"] = db.Car_Rented.Sum(x => x.t_amount);
            Session["netsum"] = db.Car_Rented.Sum(x => x.t_amount) - db.Car_Rented.Sum(x => x.t_amount) * 0.05;
            return View(data);
        }   
        public ActionResult Chart()
        {
            List<Car_Rented> data = db.Car_Rented.ToList();
            return View(data);
        }
        public ActionResult Delete(int id)
        {
            Car_Rented data = db.Car_Rented.Find(id);
            db.Car_Rented.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Chart");
        }
        public ActionResult Gallery()
        {
            return View();
        }

    }
}