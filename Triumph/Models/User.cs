using System;
using System.ComponentModel.DataAnnotations;

namespace Business.Models
{
    public class User
    {
        [Key]
        public int uid { get; set; }

        [Required]
        [Display(Name = "Username:")]
        public string username { get; set; }

        [Required]
        [Display(Name = "Email:")]
        public string email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password:")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "First Name:")]
        public string fname { get; set; }

        [Required]
        [Display(Name = "Last Name:")]
        public string lname { get; set; }

        [Required]
        [Display(Name = "Date of Birth:")]
        public DateTime birth { get; set; }

        [Required]
        [Display(Name = "Cell Phone:")]
        public int phone { get; set; }

        public DateTime createdat { get; set; }

        public DateTime updatedat { get; set; }

        public bool isAdmin { get; set; }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
