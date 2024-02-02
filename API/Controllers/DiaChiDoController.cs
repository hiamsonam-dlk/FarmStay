using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class DiaChiDoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
