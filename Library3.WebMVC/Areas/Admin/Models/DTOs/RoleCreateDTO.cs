using System.ComponentModel.DataAnnotations;

namespace Library3.WebMVC.Areas.Admin.Models.DTOs
{
    public class RoleCreateDTO
    {
        [Required(AllowEmptyStrings = false, ErrorMessage ="Enter name!")]
        public string RoleName { get; set; }
    }
}
