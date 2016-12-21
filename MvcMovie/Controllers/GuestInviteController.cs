using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class GuestInviteController : Controller
    {
        // GET: GuestInvite
        public ViewResult Index()
        {
            int hour = DateTime.Today.Hour;
            ViewBag.Greeting = hour < 12 ? "Good morning" : "Good afternoon" ;

            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", guestResponse);
            }
            else
            {
                //validation error
                return View();
            }
        }
            
    }
}