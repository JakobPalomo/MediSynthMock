using Microsoft.AspNetCore.Mvc;

namespace MediSynthFinals.Controllers
{
    public class PortalController : Controller
    {
        public IActionResult Portal()
        {
            return View();
        }
    }
}
