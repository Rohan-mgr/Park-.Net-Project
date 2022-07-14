using AutoMapper;
using DMS.DAL.DatabaseContext;
using DMS.DAL.Interfaces;
using DMS.DAL.Repositories.MainRepo;
using DMS.DAL.StaticHelper;
using DMS.Services.General.Interface;
using DMS.ViewModels;
using Microsoft.AspNet.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Net;

namespace DMS.Controllers
{
    //[CustomAuthentication]
    [AllowAnonymous]
    public class HomeController : Controller
    {
        //MainEntities db= new MainEntities();
        MainEntities db = new MainEntities();

        private SystemInfoForSession _ActiveSession;
        SystemInfoForSession systemSession = SessionHelper.GetSession();

        public HomeController(MainEntities _db)
        {
            _ActiveSession = SessionHelper.GetSession();
            db = _db;
        }

        public ActionResult Gallery()
        {
            List<gallery> data = db.galleries.ToList();
            return PartialView(data);
        }

        public ActionResult AccessDeniedPage()
        {
            return View();
        }

        public ActionResult usermessage()
        {
            //List<gallery> data = db.galleries.ToList();
            return View();
        }

        public ActionResult Index()
        {
            List<gallery> data = db.galleries.ToList();
            return View(data);
        }
        //public ActionResult LogOut()
        //{
        //    var systemSession = (SystemInfoForSession)Session["SystemSession"];

        //   AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
        //    return RedirectToAction("Index");
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public async Task<ActionResult> Dashboard()
        {
            return RedirectToAction("Index");
        }


        public ActionResult CreateMessage(User_Message user)
        {
            db.User_Message.Add(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}