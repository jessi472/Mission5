//Jessica Kinghorn Mission 4
//HomeController
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission5.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission5.Controllers
{
    public class HomeController : Controller
    {
        
        private NewMovieContext _blahContext { get; set; }

        //Catch New Movie Form object instance
        public HomeController( NewMovieContext someMovie)
        {
            
            _blahContext = someMovie;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View("Podcasts");
        }
        [HttpGet]
        public IActionResult NewMovieForm ()
        {
            ViewBag.Category = _blahContext.Category.ToList();
            return View("NewMovieForm");
        }
        [HttpPost]
        public IActionResult NewMovieForm (MovieResponse mr)
        {
            if (ModelState.IsValid)
            {
                //Filled out form gets passed to mr, sent to database
                _blahContext.Add(mr);
                _blahContext.SaveChanges();


                //View Returns success page
                return View("Confirmation");
            }
            else
            {
                ViewBag.Category = _blahContext.Category.ToList();
                return View();
            }
            
        }

        [HttpGet]
        public IActionResult MovieList()
        {
            var applications = _blahContext.Responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();
            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Category = _blahContext.Category.ToList();
            var newMovie = _blahContext.Responses.Single(movie => movie.MovieId == movieid);
            return View("NewMovieForm", newMovie);
        }

        [HttpPost]
        public IActionResult Edit (MovieResponse blah)
        {
            _blahContext.Update(blah);
            _blahContext.SaveChanges();
            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var newMovie = _blahContext.Responses.Single(movie => movie.MovieId == movieid);
            return View(newMovie);
        }

        [HttpPost]
        public IActionResult Delete (MovieResponse mr)
        {
            _blahContext.Remove(mr);
            _blahContext.SaveChanges();
            return RedirectToAction("MovieList");
        }

    }
}
