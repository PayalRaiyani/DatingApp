using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.DTOs
{
    public class UserForRegisterDto
    {
        [Required(ErrorMessage ="Username is required.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Your password should be between 4 to 8 chars long!")]
        public string Password { get; set; }
        [Required]
        public string  Gender{ get; set; }

        [Required]
        public string KnownAs { get; set; }

        [Required]
        public DateTime DateOfBirth{ get; set; }

        [Required]
        public string City{ get; set; }

        [Required]
        public string Country { get; set; }

        public DateTime Created { get; set; }
        public DateTime LastActive{ get; set; }

        public UserForRegisterDto()
        {
            Created = DateTime.Now;
            LastActive = DateTime.Now;
        }
    }
}
