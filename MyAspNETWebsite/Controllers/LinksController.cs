using MyAspNETWebsite.DAL;
using MyAspNETWebsite.Models;
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

        public ActionResult ProgLinks()
        {
            ProgLinksData linksData = new ProgLinksData();
            var linkList = linksData.GetLinks();

            return View(linkList);
        }

        [Authorize]
        public ActionResult Suggest()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Suggest(LinkSuggestion suggestion)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            else
            {
                return View();
            }

        }
    }
}