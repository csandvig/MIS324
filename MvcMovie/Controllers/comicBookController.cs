using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class ComicBookController : Controller
    {
        // GET: ComicBook
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail()
        {

            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return Redirect("/");
            }

            return Content("Today is " + DateTime.Today.DayOfWeek.ToString());
        }

    }
}
