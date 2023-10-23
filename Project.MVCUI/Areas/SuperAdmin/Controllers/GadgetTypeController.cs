using Microsoft.AspNetCore.Mvc;
using Project.BLL.Manager_Services.Abstracts;
using Project.Entities.Models;
using Project.MVCUI.Areas.SuperAdmin.Models.ViewModels;

namespace Project.MVCUI.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class GadgetTypeController : Controller
    {
        private readonly IGadgetType_Manager _manager;

        public GadgetTypeController(IGadgetType_Manager manager)
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
        public IActionResult Create(GadgetTypeVM type)
        {

            if (ModelState.IsValid)
            {
                GadgetType _type = new GadgetType()
                {
                    TypeName = type.TypeName,
                    TypeDescription = type.TypeDescription

                };
                var actives = _manager.GetActives();
                foreach (var types in actives)
                {
                    if (_type.TypeName.ToUpper() == type.TypeName.ToUpper())
                    {
                        TempData["extTypeName"] = "Bu tip zaten oluşturulmuş.";
                        return View(type);
                    }

                }
                _manager.Add(_type);
                TempData["SuccessMessage"] = "Cihaz Tipi Başarıyla Oluşturuldu !";

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

            GadgetTypeVM gadgetTypeVM = new GadgetTypeVM()
            {
                Id = type.ID,
                TypeName = type.TypeName,
                TypeDescription = type.TypeDescription
            };

            return View(gadgetTypeVM);
        }

        [HttpPost]
        public IActionResult Update(GadgetTypeVM gadgetTypeVM)
        {
            if (ModelState.IsValid)
            {
                GadgetType _gadgetType = new GadgetType()
                {
                    ID = gadgetTypeVM.Id,
                    TypeName = gadgetTypeVM.TypeName,
                    TypeDescription = gadgetTypeVM.TypeDescription

                };

                var types = _manager.GetActives();

                foreach (var type in types)
                {
                    if (_gadgetType.TypeName.ToUpper() == type.TypeName.ToUpper())
                    {
                        TempData["extTypeName"] = "Bu tip zaten oluşturulmuş.";
                        return View(gadgetTypeVM);
                    }

                }

                _manager.Update(_gadgetType);

                TempData["UpdateMessage"] = "Malzeme Tipi Başarıyla Güncellendi !";

                return RedirectToAction("Index");
            }

            return View(gadgetTypeVM);
        }

        // Delete

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var gadgetType = _manager.Find(id);
            _manager.Delete(gadgetType);
            return RedirectToAction("Index");
        }
    }
}
