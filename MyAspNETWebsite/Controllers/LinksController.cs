using MyAspNETWebsite.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyAspNETWebsite.Controllers
{
    public class LinksController : Controller
    {
        // GET: Links
        public ActionResult Index()
        {
            LinksData linksData = new LinksData();
            var linkList = linksData.GetLinks();

            return View(linkList);
        }
    }
}