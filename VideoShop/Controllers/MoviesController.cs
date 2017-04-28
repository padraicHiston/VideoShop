using System.Collections.Generic;
using System.Web.Mvc;
using VideoShop.Models;
using VideoShop.ViewModels;

namespace VideoShop.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie() { Id = 1, Name = "Shrek"},
                new Movie() { Id = 2, Name = "Wall-e"}
            };
        }



        // GET: Movies
        //public ActionResult Random()
        //{
        //    var movie = new Movie() {Name = "Shrek"};
        //    var customers = new List<Customer>()
        //    {
        //        new Customer() { Name = "Customer1"},
        //        new Customer() { Name = "Customer2"}
        //    };

        //    var viewModel = new RandomMovieViewModel()
        //    {
        //        Movie = movie,
        //        Customers = customers
        //    };

        //    return View(viewModel);
        //}

        //[Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
        //public ActionResult ByReleaseYear(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}

        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //    {
        //        pageIndex = 1;
        //    }

        //    if (String.IsNullOrWhiteSpace(sortBy))
        //    {
        //        sortBy = "Name";
        //    }

        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}
    }
}