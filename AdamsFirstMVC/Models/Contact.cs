using System.ComponentModel.DataAnnotations;


namespace AdamsFirstMVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "*First Name is Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "*Last Name is Required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "*Email is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "*A comment is Required")]
        public string Comment { get; set; }
    }
}