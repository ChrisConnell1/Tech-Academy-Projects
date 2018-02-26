using FirstChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstChallenge.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var getComics = ComicBookManager.GetComicBooks();


            return View(getComics);
        }

        public ActionResult Detail(int id)
        {
            var comics = ComicBookManager.GetComicBooks();
            var comic = comics.FirstOrDefault(p => p.ComicBookId == id);

            return View(comic);
        }
    }
}