using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FakeFacebook.Models
{
    public class Account
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public int Number { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "You did not write password!")]
        
        public string Password { get; set; }

        public int Day { get; set; }

        public string Month { get; set; }

        public int Year { get; set; }


        public string Gender { get; set; }


    }
}
