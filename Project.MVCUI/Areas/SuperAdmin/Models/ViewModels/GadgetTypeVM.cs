using System.ComponentModel.DataAnnotations;

namespace Project.MVCUI.Areas.SuperAdmin.Models.ViewModels
{
    public class GadgetTypeVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Tip adı boş geçilemez !")]
        public string TypeName { get; set; }
        [Required(ErrorMessage = "Tip açıklaması boş geçilemez !")]
        public string TypeDescription { get; set; }
    }
}
