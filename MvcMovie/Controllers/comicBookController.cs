using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMovie.Models;
using MvcMovie.Data;

namespace MvcMovie.Controllers
{
    public class ComicBookController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBookController()
        {
            _comicBookRepository = new ComicBookRepository();

        }

        // GET: ComicBook
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail(int id)
        {


            //ViewBag.ComicBook = comicBook;

            //pass model, strongly typed
            return View(ComicBookRepository.GetComicBook(id));
        }

    }
}
