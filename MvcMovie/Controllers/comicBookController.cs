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

            ViewBag.SeriesTitle = "The Amazing Spider Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final Issue! Witness the <b>final</b>...</p>";
            ViewBag.Artists = new string[]
            {
            "script: dan s",
            "pencils: Bill h",
            "colors: Edgar D",
            "letters: chris E"

            };

            return View();
        }

    }
}
