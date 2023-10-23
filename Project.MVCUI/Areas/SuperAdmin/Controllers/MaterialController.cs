using Microsoft.AspNetCore.Mvc;
using Project.BLL.Manager_Services.Abstracts;
using Project.BLL.Manager_Services.Concretes;
using Project.Entities.Models;
using Project.MVCUI.Areas.SuperAdmin.Models.ViewModels;

namespace Project.MVCUI.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class MaterialController : Controller
    {
        private readonly IMaterial_Manager _manager;
        
        public MaterialController(IMaterial_Manager manager)
        {
            _manager = manager;
        }
        //List
        public IActionResult Index()
        {
            var materials=_manager.GetActives();
            return View(materials);
        }
        //Create
        public IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(MaterialVM material)
        {
            
            if(ModelState.IsValid)
            {
                Material _material = new Material() { 
                
                    Brand=material.Brand,
                    Model=material.Model,
                    Price=material.Price,
                    Amount=material.Amount
                
                };
                var actives= _manager.GetActives();
                foreach(var materials in actives)
                {
                    if(_material.Brand.ToUpper() == material.Brand.ToUpper())
                    {
                        TempData["extBrand"] = "Bu marka zaten oluşturulmuş.";
                        return View(material);
                    }
                    else if(_material.Model.ToUpper() == material.Model.ToUpper())
                    {
                        //todo: Modeller aynı olabiliyo mu olamıyo mu diye sorulacak?
                        TempData["extModel"] = "Bu model zaten oluşturulmuş.";
                        return View(material);
                    }
                    
                }
                _manager.Add(_material);
                TempData["SuccessMessage"] = "Malzeme Başarıyla Oluşturuldu !";

                return RedirectToAction("Index");
                
            }
            else
            {
                return View(material);
            }
            
        }
        // Update
        public IActionResult Update(int id)
        {
            var material = _manager.Find(id);

            MaterialVM materialVM = new MaterialVM() 
            {
                Id=material.ID,
                Brand = material.Brand,
                Model = material.Model,
                Price = material.Price,
                Amount = material.Amount
            };

            return View(materialVM);
        }

        [HttpPost]
        public IActionResult Update(MaterialVM materialVM)
        {
            if (ModelState.IsValid)
            {
                Material _material = new Material()
                {
                    ID = materialVM.Id,
                    Brand = materialVM.Brand,
                    Model = materialVM.Model,
                    Price = materialVM.Price,
                    Amount = materialVM.Amount
                };

                var materials = _manager.GetActives();

                foreach (var material in materials)
                {
                    if(_material.Brand.ToUpper() == material.Brand.ToUpper())
                    {
                        TempData["extBrand"] = "Bu marka zaten oluşturulmuş.";
                        return View(materialVM);
                    }
                    else if (_material.Model.ToUpper() == material.Model.ToUpper())
                    {
                        //todo: Modeller aynı olabiliyo mu olamıyo mu diye sorulacak?
                        TempData["extModel"] = "Bu model zaten oluşturulmuş.";
                        return View(materialVM);
                    }
                }

                _manager.Update(_material);

                TempData["UpdateMessage"] = "Malzeme Başarıyla Güncellendi !";

                return RedirectToAction("Index");
            }

            return View(materialVM);
        }

        // Delete

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var material = _manager.Find(id);
            _manager.Delete(material);
            return RedirectToAction("Index");
        }
    }
}
