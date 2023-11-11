using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.BLL.Manager_Services.Abstracts;
using Project.Entities.Models;
using Project.MVCUI.Areas.SuperAdmin.Models.ViewModels;

namespace Project.MVCUI.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class GadgetController : Controller
    {
        private readonly IGadget_Manager _manager;
        private readonly IGadgetType_Manager _managerType;

        public GadgetController(IGadget_Manager manager, IGadgetType_Manager managerType)
        {
            _manager = manager;
            _managerType = managerType;
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
            GadgetVM _GadgetVM = new GadgetVM();
            List<SelectListItem> listItems = new List<SelectListItem>();
            foreach (var data in _managerType.GetActives())
            {
                SelectListItem listItem = new SelectListItem()
                {
                    Value = data.ID.ToString(),
                    Text = data.TypeName
                };

                listItems.Add(listItem);
            }
            _GadgetVM.gadgetTypes = listItems;
            return View(_GadgetVM);
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
                    KW_Power = gadget.KW_Power,
                    GadgetType= _managerType.Find(gadget.GadgetTypeID)

                };
                var actives = _manager.GetActives();
                foreach (var gadgets in actives)
                {
                    if (_gadget.Brand.ToUpper() == gadget.Brand.ToUpper())
                    {
                        TempData["extBrand"] = "Bu marka zaten oluşturulmuş.";
                        return View(gadget);
                    }
                    if (_gadget.Model.ToUpper() == gadget.Model.ToUpper())
                    {
                        //todo: Modeller aynı olabiliyo mu olamıyo mu diye sorulacak?
                        TempData["extModel"] = "Bu model zaten oluşturulmuş.";
                        return View(gadget);
                    }
                    if(_gadget.SerialNumber==gadget.SerialNumber)
                    {
                        TempData["extSerialNumber"] = "Bu seri numarası zaten mevcut";
                        return View(gadget);
                    }

                }
                _manager.Add(_gadget);
                TempData["SuccessMessage"] = "Cihaz Başarıyla Oluşturuldu !";

                return RedirectToAction("Index");

            }
            List<SelectListItem> listItems = new List<SelectListItem>();
            foreach (var data in _managerType.GetActives())
            {
                SelectListItem listItem = new SelectListItem()
                {
                    Value = data.ID.ToString(),
                    Text = data.TypeName
                };

                listItems.Add(listItem);
            }
            gadget.gadgetTypes = listItems;
            return View(gadget);

        }
        // Update
        public IActionResult Update(int id)
        {
            var gadget = _manager.Find(id);
            List<SelectListItem> listItems = new List<SelectListItem>();

            foreach (var data in _managerType.GetActives())
            {
                SelectListItem listItem = new SelectListItem()
                {
                    Value = data.ID.ToString(),
                    Text = data.TypeName
                };

                listItems.Add(listItem);
            }

            GadgetVM gadgetVM = new GadgetVM()
            {
                Id = gadget.ID,
                Brand = gadget.Brand,
                Model = gadget.Model,
                SerialNumber = gadget.SerialNumber,
                KW_Power = gadget.KW_Power,
                GadgetName=gadget.GadgetType.TypeName,
                gadgetTypes=listItems,
                GadgetTypeID=gadget.GadgetType.ID
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
                    KW_Power = gadgetVM.KW_Power,
                    GadgetTypeId=gadgetVM.GadgetTypeID
                };

                var gadgets = _manager.GetActives();

                foreach (var gadget in gadgets)
                {
                    if (_gadget.Brand.ToUpper() == gadget.Brand.ToUpper() && _gadget.ID!=gadgetVM.Id)
                    {
                        TempData["extBrand"] = "Bu marka zaten oluşturulmuş.";
                        return View(gadgetVM);
                    }
                    if (_gadget.Model.ToUpper() == gadget.Model.ToUpper() && _gadget.ID!=gadgetVM.Id)
                    {
                        //todo: Modeller aynı olabiliyo mu olamıyo mu diye sorulacak?
                        TempData["extModel"] = "Bu model zaten oluşturulmuş.";
                        return View(gadgetVM);
                    }
                    if(_gadget.SerialNumber==gadget.SerialNumber && _gadget.ID!=gadgetVM.Id)
                    {
                        TempData["extSerialNumber"] = "Bu seri numarası zaten mevcut";
                        return View(gadgetVM);
                    }
                }

                _manager.Update(_gadget);

                TempData["UpdateMessage"] = "Cihaz Başarıyla Güncellendi !";

                return RedirectToAction("Index");
            }
            List<SelectListItem> listItems = new List<SelectListItem>();

            foreach (var data in _managerType.GetActives())
            {
                SelectListItem listItem = new SelectListItem()
                {
                    Value = data.ID.ToString(),
                    Text = data.TypeName
                };

                listItems.Add(listItem);
            }

            gadgetVM.gadgetTypes = listItems;

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
