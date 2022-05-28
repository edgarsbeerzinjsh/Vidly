using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

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
            return View(movie);
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
        public IActionResult Index( int? pageIndex, string sortBy)
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
    }
}
