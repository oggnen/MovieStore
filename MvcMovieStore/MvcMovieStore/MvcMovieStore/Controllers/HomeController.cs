using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMovieStore.Models;
using System.Data.Entity;

namespace MvcMovieStore.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var movies = GetMostPopularMovies();
            return View(movies);
        }

        private List<Movie> GetMostPopularMovies()
        {
            return _context.Movies.OrderByDescending(m => m.MovieId).Take(8).ToList();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}