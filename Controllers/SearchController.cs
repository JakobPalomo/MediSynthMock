using Microsoft.AspNetCore.Mvc;

namespace MediSynthFinals.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Search()
        {
            return View();
        }
    }
}
