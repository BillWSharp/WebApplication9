﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using WebApplication9.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Net.Http;

namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
		
		// few changes 
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            using (var managerv2 = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext())))
            {
                var currentUser2 = managerv2.FindById(User.Identity.GetUserId());
            }

            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));

            var currentUser = manager.FindById(User.Identity.GetUserId());

            if (currentUser != null)
            {
                var myName = currentUser.Firstname;
            }
            var test = User.Identity.GetUserName();
            var userID = User.Identity.GetUserId();

            return View();

            var client = new HttpClient();

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}