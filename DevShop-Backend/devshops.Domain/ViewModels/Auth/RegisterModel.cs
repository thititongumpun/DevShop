using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devshops.Domain.ViewModels.Auth
{
    public class RegisterModel
    {
        [Required(ErrorMessage = ("Username Is Required"))]
        [StringLength(50, MinimumLength = 4)]
        public string Username { get; set; }

        [Required(ErrorMessage = ("Email Is Required"))]
        public string Email { get; set; }

        [Required(ErrorMessage = ("Password Is Required"))]
        [StringLength(50, MinimumLength = 4)]
        public string Password { get; set; }
    }
}
