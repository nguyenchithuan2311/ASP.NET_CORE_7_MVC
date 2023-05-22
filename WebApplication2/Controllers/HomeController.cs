using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        
		private readonly WebApplication2Context _context;

		public HomeController(WebApplication2Context context)
		{
			_context = context;
		}
	

        public IActionResult Index()
        {
            return View(_context.Product.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}