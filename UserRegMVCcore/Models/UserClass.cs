using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UserRegMVCcore.Models
{
    public class UserClass
    {
        [Key]
        public int UserId { get; set; }
        public string Title { get; set; }

        [Required(ErrorMessage = "Please Enter Your Name")]
        [Display(Name ="Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please Enter Your Name")]
        [Display(Name ="Your email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter The Password")]
        [DataType(DataType.Password)]
        [Display(Name ="Create a Password")]
        public string Pwd { get; set; }

        [Required(ErrorMessage = "Please Confirm The Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm your password")]
        [Compare("Pwd")]
        public string ConfirmPwd { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        [Display(Name = " I agree that I have read and accepted the eZuite User Agreement")]
        public int Agree { get; set; }



    }
}
