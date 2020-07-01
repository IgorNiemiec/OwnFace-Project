using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FakeFacebook.Dtos
{
    public class CreateAccountDto
    {

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public int Number { get; set; }

        [DataType(DataType.Password)]        
        [Required]
        public string Password { get; set; }

        public int Day { get; set; }

        public string Month { get; set; }

        public int Year { get; set; }

        [Required]
        public string Gender { get; set; }



    }
}
