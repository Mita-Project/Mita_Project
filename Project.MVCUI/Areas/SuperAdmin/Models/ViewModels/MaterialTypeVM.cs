using Project.Entities.Models;
using System.ComponentModel.DataAnnotations;

namespace Project.MVCUI.Areas.SuperAdmin.Models.ViewModels
{
    public class MaterialTypeVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Tip adı boş geçilemez !")]
        public string TypeName { get; set; }
        [Required(ErrorMessage = "Tip açıklaması boş geçilemez !")]
        public string TypeDescription { get; set; }

    }
}
