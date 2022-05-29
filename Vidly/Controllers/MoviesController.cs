using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Random()
        //public ViewResult Random()
        {
            var movie = new Movie()
            {
                Name = "Shrek! "
            };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
            //ViewData["Movie"] = movie; <--- noteikti izvairities
            //return View(movie);
            //return View();
            //return new ViewResult();
            //return Content("Hello World!");
            //return new NotFoundResult();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }
        public IActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
        // movies
        public IActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            return Content(String.Format("pageIndex={0}&sortBy{1}", pageIndex, sortBy));
        }
        [Route("movies/released/{year}/{month:range(1,12):regex(\\d{{2}})}")]
        public IActionResult ByReleaseDate(int? year, int? month)
        {
            return Content(year + "/" + month);
        }

    }
}
