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
            //return View(movie);
            //return new ViewResult();
            return Content("Hello World!");
        }
    }
}
