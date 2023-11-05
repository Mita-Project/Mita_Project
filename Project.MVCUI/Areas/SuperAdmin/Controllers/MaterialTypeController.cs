using Microsoft.AspNetCore.Mvc;
using Project.BLL.Manager_Services.Abstracts;
using Project.Entities.Models;
using Project.MVCUI.Areas.SuperAdmin.Models.ViewModels;

namespace Project.MVCUI.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class MaterialTypeController : Controller
    {
        private readonly IMaterialType_Manager _manager;

        public MaterialTypeController(IMaterialType_Manager manager)
        {
            _manager = manager;
        }
        //List
        public IActionResult Index()
        {
            var types = _manager.GetActives();
            return View(types);
        }
        //Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(MaterialTypeVM type)
        {

            if (ModelState.IsValid)
            {
                MaterialType _type = new MaterialType()
                {
                    TypeName=type.TypeName,
                    TypeDescription=type.TypeDescription

                };
                var actives = _manager.GetActives();
                foreach (var types in actives)
                {
                    if (_type.TypeName.ToUpper() == types.TypeName.ToUpper())
                    {
                        TempData["extTypeName"] = "Bu tip zaten oluşturulmuş.";
                        return View(types);
                    }

                }
                _manager.Add(_type);
                TempData["SuccessMessage"] = "Malzeme Tipi Başarıyla Oluşturuldu !";

                return RedirectToAction("Index");

            }
            else
            {
                return View(type);
            }

        }
        // Update
        public IActionResult Update(int id)
        {
            var type = _manager.Find(id);

            MaterialTypeVM materialTypeVM = new MaterialTypeVM()
            {
                Id = type.ID,
                TypeName=type.TypeName,
                TypeDescription=type.TypeDescription
            };

            return View(materialTypeVM);
        }

        [HttpPost]
        public IActionResult Update(MaterialTypeVM materialTypeVM)
        {
            if (ModelState.IsValid)
            {
                MaterialType _materialType = new MaterialType()
                {
                   ID=materialTypeVM.Id,
                   TypeName=materialTypeVM.TypeName,
                   TypeDescription=materialTypeVM.TypeDescription

                };

                var types = _manager.GetActives();

                foreach (var type in types)
                {
                    if (_materialType.TypeName.ToUpper() == type.TypeName.ToUpper())
                    {
                        TempData["extTypeName"] = "Bu tip zaten oluşturulmuş.";
                        return View(materialTypeVM);
                    }
                    
                }

                _manager.Update(_materialType);

                TempData["UpdateMessage"] = "Malzeme Tipi Başarıyla Güncellendi !";

                return RedirectToAction("Index");
            }

            return View(materialTypeVM);
        }

        // Delete

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var materialType = _manager.Find(id);
            _manager.Delete(materialType);
            return RedirectToAction("Index");
        }
    }
}
