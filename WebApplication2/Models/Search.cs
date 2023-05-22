using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;

namespace WebApplication2.Models
{
	public class Search:ViewComponent
	{
		private readonly WebApplication2Context _context;

		public Search(WebApplication2Context context)
		{
			_context = context;
		}
		public IViewComponentResult Invoke()
		{
			return View(_context.Category.ToList());
		}
	}
}
