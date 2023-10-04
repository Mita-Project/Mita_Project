using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.Manager_Services.Abstracts;
using Project.Entities.Models;

namespace Project.MVCUI.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class RoleController : Controller
    {
        private readonly IRole_Manager _manager;

        private readonly RoleManager<Role> _roleManager;

        public RoleController(IRole_Manager manager, RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
            _manager = manager;
        }

        public IActionResult Index()
        {
            var roles = _manager.GetActives();
            return View(roles);
        }
    }
}
