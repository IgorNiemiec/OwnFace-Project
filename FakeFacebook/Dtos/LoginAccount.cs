using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FakeFacebook.Dtos
{
    public class LoginAccount
    {

        [Required(ErrorMessage ="Musisz podać email")]
        public string Email { get; set; }


        [Required(ErrorMessage ="Musisz podać hasło")]
        public string Password { get; set; }


     
    }



}
