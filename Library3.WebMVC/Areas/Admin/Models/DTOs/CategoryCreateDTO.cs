using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library3.WebMVC.Areas.Admin.Models.DTOs
{
    public class CategoryCreateDTO
    {
        //----------------------------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage ="Enter Category Name!")]

        public string CategoryName { get; set; }
        //----------------------------------------------------------------------
        [NotMapped]
        public IFormFile? CategoryPhoto { get; set; }

        public string? CategoryPhotoName { get; set; }
    }
}
