using MyAspNETWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyAspNETWebsite.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Index(PrivateMessage message)
        {
            if (ModelState.IsValid)
            {
                // Itt lehetne elküldeni e-mailben a linket az adminnak

                return View("MessageSent", message);
            }
            else
            {
                return View();
            }
        }
    }
}