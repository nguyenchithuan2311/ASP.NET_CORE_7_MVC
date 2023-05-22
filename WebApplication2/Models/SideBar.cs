using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;

namespace WebApplication2.Models
{

	public class SideBar: ViewComponent
	{
		private readonly WebApplication2Context _context;

		public SideBar(WebApplication2Context context)
		{
			_context = context;
		}
		public IViewComponentResult Invoke()
		{ return View("Demo",_context.Category.ToList()); }
	}
}
