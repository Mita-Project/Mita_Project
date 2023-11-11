using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Project.MVCUI.Areas.SuperAdmin.Models.ViewModels
{
    public class CompanyVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Şirket adı boş geçilemez !")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Şirket vergi kimlik numarası boş geçilemez !")]
        public string Company_VKN { get; set; }
        [Required(ErrorMessage = "Şirket adresi boş geçilemez !")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Şirkete ait telefon numarası boş geçilemez !")]
        public string CompanyTelNo { get; set; }
        [Required(ErrorMessage = "Yetkili adı boş geçilemez !")]
        public string ContactPersonName { get; set; }
        [Required(ErrorMessage = "Yetkiliye ait telefon numarası boş geçilemez !")]
        public string ContactPersonTelNo { get; set; }
        [Required(ErrorMessage = "Yetkiliye ait e-mail boş geçilemez !")]
        public string ContactPersonMail { get; set; }
        [Required(ErrorMessage = "Şirkete ait e-mail boş geçilemez !")]
        public string CompanyMail { get; set; }
        public string CompanyLogoFilePath { get; set; }

      
    }
}
