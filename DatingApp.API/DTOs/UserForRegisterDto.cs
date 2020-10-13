using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.DTOs
{
    public class UserForRegisterDto
    {
        [Required]
        public  string Username { get; set; }

        [Required]
        [StringLength(8,MinimumLength =4,ErrorMessage ="Your password should be between 4 to 8 chars long!")]
        public string  Password { get; set; }
    }
}
