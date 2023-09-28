using Microsoft.AspNetCore.Mvc;

namespace Project.MVCUI.Areas.SuperAdmin.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
