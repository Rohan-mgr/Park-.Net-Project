using DMS.DAL.DatabaseContext;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DMS.Controllers
{
    public class GalleryController : Controller
    {
        MainEntities db = new MainEntities();
        // GET: Gallery
        public ActionResult Index()
        {
            List<gallery> data = db.galleries.ToList();
            return View(data);
        }

        public ActionResult AddNew()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveImage(string carname, HttpPostedFileBase SelectedFile)
        {
            string path = Server.MapPath("~/Uploads");
            string filename = SelectedFile.FileName;
            string new_path = path + "/" + filename;
            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            SelectedFile.SaveAs(new_path);
            gallery gallery = new gallery();
            gallery.photo_path = "~/Uploads";
            gallery.photo_name = filename;
            gallery.car_name = carname; 
            db.galleries.Add(gallery);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}