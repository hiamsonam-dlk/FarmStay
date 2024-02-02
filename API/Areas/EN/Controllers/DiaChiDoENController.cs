using Microsoft.AspNetCore.Mvc;

namespace API.Areas.EN.Controllers
{
    [Area("EN")]
    public class DiaChiDoENController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
