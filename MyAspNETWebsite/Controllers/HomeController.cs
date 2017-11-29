using MyAspNETWebsite.DAL;
using MyAspNETWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyAspNETWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            PersonData personData = new PersonData();
            Person person = personData.GetPersonData();

            return View(person);
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}