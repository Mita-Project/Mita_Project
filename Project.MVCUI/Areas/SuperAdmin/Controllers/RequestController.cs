using Microsoft.AspNetCore.Mvc;
using Project.BLL.Manager_Services.Abstracts;
using Project.Entities.Models;
using Project.MVCUI.Areas.SuperAdmin.Models.ViewModels;

namespace Project.MVCUI.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class RequestController : Controller
    {
        private readonly IRequest_Manager _manager;
        public RequestController(IRequest_Manager manager)
        {
            _manager = manager;
        }

        //List
        public IActionResult Index()
        {
            var requests=_manager.GetActives();
            return View(requests);
        }
        //Create
        #region Create
        public IActionResult Create() 
        {
            RequestVM _RequestVM= new RequestVM();
            return View(_RequestVM);    
        }

        [HttpPost]
        public IActionResult Create(RequestVM request) 
        {
            if(ModelState.IsValid)
            {
                Request _request = new Request()
                {
                    RequestTopic = request.RequestTopic,
                    RequestDescription = request.RequestDescription
                };
                //todo:Talep numarası eklenecek. Ayrıca Index'inde şimdilik talep silerken talebin konusu gösteriliyor bu sayede talep konusu yerine talep numarasını dahil etmemiz gerek.
                _manager.Add(_request);
                TempData["Success Message"] = "Talep başarıyla oluşturuldu !";
                return RedirectToAction("Index");
            }
            return View(request);

        }
        #endregion
        public IActionResult Update(int id)
        {
            var request = _manager.Find(id);
            RequestVM requestVM = new RequestVM()
            {
                Id = request.ID,
                RequestTopic = request.RequestTopic,
                RequestDescription = request.RequestDescription
            };
            return View(requestVM);
        }
        [HttpPost]
        public IActionResult Update(RequestVM requestVM)
        {
            if(ModelState.IsValid)
            {
                Request _request = new Request()
                {
                    ID=requestVM.Id,
                    RequestTopic = requestVM.RequestTopic,
                    RequestDescription = requestVM.RequestDescription
                };
                _manager.Update(_request);
                TempData["UpdateMessage"] = "Talep Başarıyla Güncellendi !";
                return RedirectToAction("Index");
            }
            return View(requestVM);
        }
        [HttpGet]
        public IActionResult Delete(int id) 
        {
            var request = _manager.Find(id);
            _manager.Delete(request);
            return RedirectToAction("Index");
        }
    }
}
