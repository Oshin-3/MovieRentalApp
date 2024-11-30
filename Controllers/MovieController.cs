using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using MovieRentalApp.Models;
using System.Data.Entity;


namespace MovieRentalApp.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
       
        //public ActionResult Random()
        //{
        //    var movies = new Movies() { Title = "Dune 2!" };

        //    var customers = new List<Customers>
        //    { 
        //        new Customers { Name = "Customer 1"},
        //        new Customers { Name = "Customer 2"}
            
        //    };

        //    var randomMovie = new RandomViewModel()
        //    {
        //        Movies = movies,
        //        Customers = customers
        //    };

        //    return View(randomMovie);
        //}

        ////Action parameters
        ////1. URL and 2. Query string
        //public ActionResult Edit(int id) { 
            
        //    return Content("Id from the URL : " +  id);
        //}

        //public ActionResult Index(int? pageNo, string sortBy)
        //{
        //    if (!pageNo.HasValue)
        //    {
        //        pageNo = 1;
        //    }

        //    if (string.IsNullOrWhiteSpace(sortBy))
        //    {
        //        sortBy = "Name";
        //    }

        //    return Content(String.Format("pageNo={0}&sortBy={1}", pageNo, sortBy));
        //}

        //[Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2})}")]
        //public ActionResult ByReleasedDate(int year, int month) 
        //{ 
        //    return Content(String.Format("Released Date : {0}/{1}", year, month));
        //}
        private ApplicationDbContext _context;

        public MovieController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Movies()
        {
            //var movies = GetMovies();
            var movies = _context.Movies.Include(m => m.Genres).ToList();
            return View(movies);
        }

        public ActionResult Details(int? id) 
        {
            var movie = _context.Movies.Include(m => m.Genres).SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            else { 
                return View(movie);
            }
        }

        //private IEnumerable<Movies> GetMovies()
        //{
        //    return new List<Movies>
        //    {
        //        new Movies { Id = 100, Title = "Dune 2"},
        //        new Movies { Id = 101, Title = "Wicked"}
        //    };
        //}
    }
}