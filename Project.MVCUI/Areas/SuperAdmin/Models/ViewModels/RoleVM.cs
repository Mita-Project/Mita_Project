using System.ComponentModel.DataAnnotations;

namespace Project.MVCUI.Areas.SuperAdmin.Models.ViewModels
{
    public class RoleVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Rol adı boş geçilemez !")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Rol açıklaması boş geçilemez !")] 
        public string Role_Exp { get; set; }
    }
}
