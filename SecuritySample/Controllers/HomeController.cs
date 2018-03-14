﻿using SecuritySample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Infra;

namespace SecuritySample.Controllers
{
    public class HomeController : Controller
    {
        private LoginDetails Loginn = new LoginDetails();
        //public ActionResult Index1()
        //{
        //    return View();
        //}
        [NoAntiForgeryCheck]
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            var logon = new LoginDetails();
            return View("~/Views/Login/LoginCRSFPage.cshtml", logon);
        }
        [HttpPost]
        public ActionResult CSRFLogin(LoginDetails Login)
        {
            var Loginn = Login;
            return RedirectToAction("About", "Home");
            //return View("~/Views/Home/LoginPage.cshtml", Login);
        }
        [HttpPost]
        public ActionResult Login(LoginDetails logon)
        {
            if (ValidateUser(logon, Response))
            {
                return RedirectToAction("DefaultHome", "Home");
            }
            else
            {
                ModelState.AddModelError("CustomError", "The user name or password provided is incorrect.");
                return View("~/Views/Account/LoginPage.cshtml");
            }
        }
        private bool ValidateUser(LoginDetails logon, HttpResponseBase response)
        {

            return true;
        }
        public ActionResult About(LoginDetails Loginn)
        {
            ViewBag.Message = "Your application description page.";

            return View("~/Views/Home/About.cshtml");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}