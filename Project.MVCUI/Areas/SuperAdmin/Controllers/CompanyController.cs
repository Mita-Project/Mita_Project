using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Identity.Client;
using Project.BLL.Manager_Services.Abstracts;
using Project.Entities.Models;
using Project.MVCUI.Areas.SuperAdmin.Models.ViewModels;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Project.MVCUI.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class CompanyController : Controller
    {
        private readonly ICompany_Manager _manager;
        
         public CompanyController(ICompany_Manager manager)
        {
            _manager = manager;
           
        }
        //List
        public IActionResult Index()
        {
            var companies= _manager.GetActives();
            return View(companies);
        }
        //Create
        public IActionResult Create()
        {
            CompanyVM _CompanyVM = new CompanyVM();
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(CompanyVM company) 
        {
            if(ModelState.IsValid)
            {
                Company _company = new Company() 
                {
                    CompanyName = company.CompanyName,
                    Company_VKN = company.Company_VKN,
                    Address = company.Address,
                    CompanyTelNo = company.CompanyTelNo,
                    ContactPersonName=company.ContactPersonName,
                    ContactPersonTelNo=company.ContactPersonTelNo,
                    ContactPersonMail=company.ContactPersonMail,
                    CompanyMail=company.CompanyMail,
                    CompanyLogoFilePath=company.CompanyLogoFilePath
                    
                };
                var actives= _manager.GetActives();
                foreach (var companies in actives)
                {
                    if (_company.CompanyName.ToUpper() == company.CompanyName.ToUpper())
                    {
                        TempData["extCompanyName"] = "Bu şirket ismi zaten mevcut.";
                        return View(company);
                    }
                    if (_company.Company_VKN == company.Company_VKN)
                    {
                        
                        TempData["extCompanyVKN"] = "Bu vergi kimlik numarası zaten mevcut.";
                        return View(company);
                    }
                    if (_company.Address.ToUpper() == company.Address.ToUpper())
                    {
                        TempData["extAddress"] = "Bu adres zaten mevcut";
                        return View(company);
                    }
                    if (_company.CompanyMail.ToUpper() == company.CompanyMail.ToUpper())
                    {
                        TempData["extCompanyMail"] = "Bu e-mail zaten mevcut";
                        return View(company);
                    }
                    if (_company.CompanyTelNo == company.CompanyTelNo)
                    {
                        TempData["extCompanyTelNo"] = "Bu şirket telefon numarası zaten mevcut";
                        return View(company);
                    }

                }
                _manager.Add(_company);
                TempData["SuccessMessage"] = "Şirket Başarıyla Oluşturuldu !";
                return RedirectToAction("Index");
            }
            return View(company);
            
            
        }
        //Update
        public IActionResult Update(int id)
        {
            var company = _manager.Find(id);
            CompanyVM companyVM = new CompanyVM()
            {
                Id=company.ID,
                CompanyName = company.CompanyName,
                Company_VKN = company.Company_VKN,
                Address = company.Address,
                CompanyTelNo = company.CompanyTelNo,
                ContactPersonName = company.ContactPersonName,
                ContactPersonTelNo = company.ContactPersonTelNo,
                ContactPersonMail = company.ContactPersonMail,
                CompanyMail = company.CompanyMail,
                CompanyLogoFilePath = company.CompanyLogoFilePath
            };
            return View(companyVM);
        }
        [HttpPost]
        public IActionResult Update(CompanyVM companyVM) 
        {
            if(ModelState.IsValid)
            {
                Company _company=new Company() 
                {
                    ID=companyVM.Id,
                    CompanyName = companyVM.CompanyName,
                    Company_VKN = companyVM.Company_VKN,
                    Address = companyVM.Address,
                    CompanyTelNo = companyVM.CompanyTelNo,
                    ContactPersonName = companyVM.ContactPersonName,
                    ContactPersonTelNo = companyVM.ContactPersonTelNo,
                    ContactPersonMail = companyVM.ContactPersonMail,
                    CompanyMail = companyVM.CompanyMail,
                    CompanyLogoFilePath = companyVM.CompanyLogoFilePath
                };
                var companies=_manager.GetActives();
                foreach (var company in companies)
                {
                    if (_company.CompanyName.ToUpper() == company.CompanyName.ToUpper())
                    {
                        TempData["extCompanyName"] = "Bu şirket ismi zaten mevcut.";
                        return View(company);
                    }
                    if (_company.Company_VKN == company.Company_VKN)
                    {

                        TempData["extCompanyVKN"] = "Bu vergi kimlik numarası zaten mevcut.";
                        return View(company);
                    }
                    if (_company.Address.ToUpper() == company.Address.ToUpper())
                    {
                        TempData["extAddress"] = "Bu adres zaten mevcut";
                        return View(company);
                    }
                    if (_company.CompanyMail.ToUpper() == company.CompanyMail.ToUpper())
                    {
                        TempData["extCompanyMail"] = "Bu e-mail zaten mevcut";
                        return View(company);
                    }
                    if (_company.CompanyTelNo == company.CompanyTelNo)
                    {
                        TempData["extCompanyTelNo"] = "Bu şirket telefon numarası zaten mevcut";
                        return View(company);
                    }

                }
                _manager.Update(_company);
                TempData["UpdateMessage"] = "Şirket Başarıyla Güncellendi !";

                return RedirectToAction("Index");
            }
            return View(companyVM);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var company = _manager.Find(id);
            _manager.Delete(company);
            return RedirectToAction("Index");
        }
    }
}
