using carousel.Data; // Ensure this matches your project's namespace
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; // Required for DbContext methods
using System.Threading.Tasks; // Needed for async/await
using System.Collections.Generic; // Needed for List<T>

namespace carousel.Controllers
{
    public class CarouselController : Controller
    {
        private readonly ApplicationDbContext _context; // DbContext to access database

        // Constructor to inject the ApplicationDbContext
        public CarouselController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Asynchronous action method to get carousel items
        public async Task<IActionResult> Index()
        {
            var carouselItems = await _context.CarouselItems.ToListAsync(); // Fetch data from database
            return View(carouselItems); // Pass the data to the view
        }
    }
}
