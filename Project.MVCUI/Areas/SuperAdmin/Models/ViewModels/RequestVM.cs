using Project.Entities.Models;
using System.ComponentModel.DataAnnotations;

namespace Project.MVCUI.Areas.SuperAdmin.Models.ViewModels
{
    public class RequestVM
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "Talep konusu boş bırakılamaz !")]
        public string? RequestTopic { get; set; }
        [Required(ErrorMessage = "Talep açıklaması boş bırakılamaz !")]
        public string? RequestDescription { get; set; }

        //Relations

        //todo: Talep sayfasında sadece konu ve açıklama gözüküyor. Şirket ve Şube alanları bakılıp eklenecek.
        public virtual Company? Company { get; set; }
        public int CompanyId { get; set; }

        public virtual Branch? Branch { get; set; }
        public int BranchId { get; set; }
    }
}
