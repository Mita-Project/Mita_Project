using Microsoft.AspNetCore.Mvc;

namespace Project.MVCUI.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
