using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CommonController : Controller
    {
        [Route("/Error")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
