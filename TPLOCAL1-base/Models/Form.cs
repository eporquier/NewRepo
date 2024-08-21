using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TPLOCAL1.Models
{
    public class Form
    {
        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "Last name should be between 4 and 30 characters")]
        public string FirstName
        {
            get; set;
        }
        [Required(ErrorMessage = "Please enter your forname")]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "Forname should be between 4 and 30 characters")]
        public string ForName
        {
            get; set;
        }
        [Required(ErrorMessage = "Please enter your gender")]
        public string Gender
        {
            get; set;
        }

        [Required(ErrorMessage = "Email id is required")]
        [RegularExpression(@"^([\w]+)@([\w]+)\.( [\w]+)$", ErrorMessage = "Please enter a valid email address")]
        public string EmailId
        {
            get; set;
        }
        [Required(ErrorMessage = "Zip Code is required")]
        [RegularExpression(@"[0-9]{5}", ErrorMessage = "Please enter only numerical values")]
        public string ZipCode
        {
            get; set;
        }
        [Required(ErrorMessage = "Please enter your address")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Address too short")]
        public string Address 
        {
            get; set;
        }
        [Required(ErrorMessage = "Please enter your city")]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "City should be between 4 and 30 characters")]
        public string City
        {
            get; set;
        }
        [Required]
        [Display(Name = "DateDebut")]
        public string? DateDebut 
        { 
            get; set; 
        }

        [Required]
        [Display(Name = "Formation")]
        public string? Formation 
        { 
            get; set; 
        }


        [Display(Name = "AvisCOBOL")]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "Please write your rating between 4 and 30 characters")]
        public string? AvisCOBOL 
        { 
            get; set; 
        }


        [Display(Name = "AvisCSharp")]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "Please write your rating between 4 and 30 characters")]
        public string? AvisCSharp 
        { 
            get; set; 
        }
    }

}
