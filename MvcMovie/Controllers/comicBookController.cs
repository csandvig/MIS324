using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMovie.Models;

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
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final Issue! Witness the <b>final</b>...</p>",
                Artists = new Artist[]
                {
                    new Artist() {Name = "Dan", Role = "Script" },
                    new Artist() {Name = "Sam", Role = "Pencils" },
                    new Artist() {Name = "Victor", Role = "Inks" },
                    new Artist() {Name = "Apollo", Role = "Colors" },
                    new Artist() {Name = "Kai", Role = "Letters" }
                }
            };

            //ViewBag.ComicBook = comicBook;

            //pass model, strongly typed
            return View(comicBook);
        }

    }
}
