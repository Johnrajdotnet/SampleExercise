using SecuritySample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecuritySample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //int j = 0;
            //var i = 1 / j;
            return View();
        }
        [HttpPost]
        public JsonResult GetAutoCountryList(string inputPrefix) {
            CountryDetails countryDetails = new CountryDetails();
            //Searching records from list using LINQ query  
            var countryList = countryDetails.CountryListDetails.Where(x => x.CountryName.StartsWith(inputPrefix)).ToList();
            return Json(countryList, JsonRequestBehavior.AllowGet);
        }
    }
}