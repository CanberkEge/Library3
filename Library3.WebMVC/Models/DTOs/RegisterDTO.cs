using System.ComponentModel.DataAnnotations;

namespace Library3.WebMVC.Models.DTO_s
{
    public class RegisterDTO
    {
        //-----------------------------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Name!")]
        public string Name { get; set; }
        //-----------------------------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Surname!")]
        public string Surname { get; set; }
        //-----------------------------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Email!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        //-----------------------------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Password!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        //-----------------------------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter RePassword!")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords Do Not Match")]
        public string RePassword { get; set; }
        //-----------------------------------------------------------------------
    }
}
