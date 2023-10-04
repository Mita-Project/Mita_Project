using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.Manager_Services.Abstracts;
using Project.Entities.Models;
using Project.MVCUI.Areas.SuperAdmin.Models.ViewModels;

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

        //List
        public IActionResult Index()
        {
            var roles = _manager.GetActives();
            return View(roles);
        }

        //Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(RoleVM role)
        {
            if(ModelState.IsValid)
            {
                Role _role=new Role();
                _role.Name = role.Name;
                _role.Role_Exp = role.Role_Exp;

                var result = await _roleManager.CreateAsync(_role);

                if (result.Succeeded)
                {
                    TempData["SuccessMessage"] = "Kullanıcı Rolü Başarıyla Oluşturuldu !";

                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["ExtTypeName"] = "Bu rol zaten mevcut !";
                    return View(role);
                }
            }
            return View(role);
        }
        //Update

        public IActionResult Update(int id)
        {
            var role = _manager.Find(id);
            RoleVM _role = new RoleVM();
            _role.Id = id;
            _role.Name = role.Name;
            _role.Role_Exp= role.Role_Exp;
            return View(_role);
        }

        [HttpPost]

        public IActionResult Update(RoleVM role) 
        {
            if (ModelState.IsValid)
            {
                Role _role=new Role();
                _role.Id= role.Id;
                _role.ID=role.Id;
                _role.Name=role.Name;
                _role.Role_Exp=role.Role_Exp;

                var roles=_manager.GetActives();

                foreach(var i in roles)
                {
                    if(i.Name==_role.Name && i.Id!=role.Id) 
                    {
                        TempData["ExtTypName"] = "Bu rol zaten mevcut";
                        return View(role);
                    }
                }
                _manager.Update(_role);
                TempData["UpdateMessage"] = "Rol kaydı başarıyla güncellendi !";
                return RedirectToAction("Index");
            }
            return View(role);
        }
        //Delete
        [HttpGet]
        public IActionResult Delete(int id) 
        {
            var data=_manager.Find(id);
            _manager.Delete(data);
            return RedirectToAction("Index");   
        }


    }
}
