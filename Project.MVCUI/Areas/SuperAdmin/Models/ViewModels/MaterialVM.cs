using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Project.MVCUI.Areas.SuperAdmin.Models.ViewModels
{
    public class MaterialVM
    {
        public int Id { get; set; }
        
        //todo: Material name is not in Material Entity. It should check.

        [Required(ErrorMessage = "Marka boş geçilemez !")]
        public string Brand { get; set; }
        [Required(ErrorMessage = "Model boş geçilemez !")]
        public string Model { get; set; }
        [Required(ErrorMessage = "Fiyat boş geçilemez !")]
        public decimal? Price { get; set; }
        [Required(ErrorMessage = "Miktar boş geçilemez !")]
        public int? Amount { get; set; }
        public IEnumerable<SelectListItem>? materialTypes { get; set; }
        public int MaterialTypeID { get; set; }
        public string? MaterialName { get; set; }

    }
}
