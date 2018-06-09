using System;
using System.ComponentModel.DataAnnotations;

namespace Business.Models
{
    public class ClientModel
    {
        [Key]
        public int cuid { get; set; }

        [Key]
        [Required]
        [Display(Name = "Company Name:")]
        public string comp_name { get; set; }

        [Display(Name = "Address:")]
        public string address { get; set; }

        [Display(Name = "City:")]
        public string city { get; set; }

        [Display(Name = "State:")]
        public string state { get; set; }

        [Display(Name = "zip:")]
        public string zip { get; set; }

        [Required]
        [Display(Name = "Contact Number:")]
        public int contact_num { get; set; }

        [Required]
        [Display(Name = "Contact Name:")]
        public string contact_name { get; set; }

        [Required]
        [Display(Name = "Contact Email:")]
        public string contact_email { get; set; }

        [Display(Name = "Username:")]
        public string notes { get; set; }
    }
}
