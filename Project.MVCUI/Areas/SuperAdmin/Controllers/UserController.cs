using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.Manager_Services.Abstracts;
using Project.Entities.Models;

namespace Project.MVCUI.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class UserController : Controller
    {
        private readonly IUser_Manager _custom_user_manager;
        private readonly UserManager<User> _usermanager;

        public UserController(IUser_Manager custom_user_manager, UserManager<User> usermanager)
        {
            _custom_user_manager = custom_user_manager;
            _usermanager = usermanager;
        }

        //List

        public IActionResult Index()
        {
            var users = _custom_user_manager.GetActives();

            return View(users);
        }
    }
}
