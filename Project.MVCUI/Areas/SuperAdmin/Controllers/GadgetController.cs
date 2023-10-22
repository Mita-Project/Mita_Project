using Microsoft.AspNetCore.Mvc;
using Project.BLL.Manager_Services.Abstracts;
using Project.Entities.Models;
using Project.MVCUI.Areas.SuperAdmin.Models.ViewModels;

namespace Project.MVCUI.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class GadgetController : Controller
    {
        private readonly IGadget_Manager _manager;

        public GadgetController(IGadget_Manager manager)
        {
            _manager = manager;
        }
        //List
        public IActionResult Index()
        {
            var gadgets = _manager.GetActives();
            return View(gadgets);
        }
        //Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(GadgetVM gadget)
        {

            if (ModelState.IsValid)
            {
                Gadget _gadget = new Gadget()
                {

                    Brand = gadget.Brand,
                    Model = gadget.Model,
                    SerialNumber = gadget.SerialNumber,
                    KW_Power = gadget.KW_Power

                };
                var actives = _manager.GetActives();
                foreach (var gadgets in actives)
                {
                    if (_gadget.Brand.ToUpper() == gadget.Brand.ToUpper())
                    {
                        TempData["extBrand"] = "Bu marka zaten oluşturulmuş.";
                        return View(gadget);
                    }
                    else if (_gadget.Model.ToUpper() == gadget.Model.ToUpper())
                    {
                        //todo: Modeller aynı olabiliyo mu olamıyo mu diye sorulacak?
                        TempData["extModel"] = "Bu model zaten oluşturulmuş.";
                        return View(gadget);
                    }
                    else if(_gadget.SerialNumber==gadget.SerialNumber)
                    {
                        TempData["extSerialNumber"] = "Bu seri numarası zaten mevcut";
                        return View(gadget);
                    }

                }
                _manager.Add(_gadget);
                TempData["SuccessMessage"] = "Cihaz Başarıyla Oluşturuldu !";

                return RedirectToAction("Index");

            }
            else
            {
                return View(gadget);
            }

        }
        // Update
        public IActionResult Update(int id)
        {
            var gadget = _manager.Find(id);

            GadgetVM gadgetVM = new GadgetVM()
            {
                Id = gadget.ID,
                Brand = gadget.Brand,
                Model = gadget.Model,
                SerialNumber = gadget.SerialNumber,
                KW_Power = gadget.KW_Power
            };

            return View(gadgetVM);
        }

        [HttpPost]
        public IActionResult Update(GadgetVM gadgetVM)
        {
            if (ModelState.IsValid)
            {
                Gadget _gadget = new Gadget()
                {
                    ID = gadgetVM.Id,
                    Brand = gadgetVM.Brand,
                    Model = gadgetVM.Model,
                    SerialNumber = gadgetVM.SerialNumber,
                    KW_Power = gadgetVM.KW_Power
                };

                var gadgets = _manager.GetActives();

                foreach (var gadget in gadgets)
                {
                    if (_gadget.Brand.ToUpper() == gadget.Brand.ToUpper())
                    {
                        TempData["extBrand"] = "Bu marka zaten oluşturulmuş.";
                        return View(gadgetVM);
                    }
                    else if (_gadget.Model.ToUpper() == gadget.Model.ToUpper())
                    {
                        //todo: Modeller aynı olabiliyo mu olamıyo mu diye sorulacak?
                        TempData["extModel"] = "Bu model zaten oluşturulmuş.";
                        return View(gadgetVM);
                    }
                    else if(_gadget.SerialNumber==gadget.SerialNumber)
                    {
                        TempData["extSerialNumber"] = "Bu seri numarası zaten mevcut";
                        return View(gadgetVM);
                    }
                }

                _manager.Update(_gadget);

                TempData["UpdateMessage"] = "Cihaz Başarıyla Güncellendi !";

                return RedirectToAction("Index");
            }

            return View(gadgetVM);
        }

        // Delete

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var gadget = _manager.Find(id);
            _manager.Delete(gadget);
            return RedirectToAction("Index");
        }
    }
}
