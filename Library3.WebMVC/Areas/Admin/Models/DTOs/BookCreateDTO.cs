using Library3.Entity.Concrete;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library3.WebMVC.Areas.Admin.Models.DTOs
{
    public class BookCreateDTO
    {
        //--------------------------------------------------------------------
        [Required (AllowEmptyStrings = false, ErrorMessage = "Enter book name!")]

        public string Title { get; set; }
        //--------------------------------------------------------------------
        public string? Description { get; set; }
        //--------------------------------------------------------------------
        public string? BookName { get; set; }
        //--------------------------------------------------------------------
        public int? PageNumber { get; set; }
        //--------------------------------------------------------------------
        public string? Author { get; set; }
        //--------------------------------------------------------------------
        public string? Edition { get; set; }
        //--------------------------------------------------------------------
        public double Price { get; set; }
        //--------------------------------------------------------------------
        public DateTime? ReserveDate { get; set; }
        //--------------------------------------------------------------------
        public DateTime? DueDate { get; set; }
        //--------------------------------------------------------------------
        public DateTime? ReturnDate { get; set; }
        //--------------------------------------------------------------------


        public Category? Category { get; set; }
        //--------------------------------------------------------------------
        public Reader? Reader { get; set; }
        //--------------------------------------------------------------------
        public Publisher? Publisher { get; set; }
        //--------------------------------------------------------------------
        public Staff? Staff { get; set; }

        [NotMapped]

        public IFormFile BookPhoto { get; set; }
        //--------------------------------------------------------------------

        public string? BookPhotoName { get; set; }
        //--------------------------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage ="Select book category!")]
        public int? CategoryId { get; set;}
    }
}
