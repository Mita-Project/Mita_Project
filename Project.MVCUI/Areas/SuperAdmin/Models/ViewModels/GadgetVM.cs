using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Project.MVCUI.Areas.SuperAdmin.Models.ViewModels
{
    public class GadgetVM
    {
        public int Id {  get; set; }
        [Required(ErrorMessage = "Marka adı boş geçilemez !")]
        public string Brand { get; set; }
        [Required(ErrorMessage = "Model adı boş geçilemez !")]
        public string Model { get; set; }
        [Required(ErrorMessage = "Seri numarası boş geçilemez !")]
        public string SerialNumber { get; set; }
        [Required(ErrorMessage = "Cihaz gücü alanı boş geçilemez !")]
        public double KW_Power { get; set; }
        public IEnumerable<SelectListItem>? gadgetTypes { get; set; }
        public int GadgetTypeID { get; set; }
        public string? GadgetName { get; set; }
    }
}
