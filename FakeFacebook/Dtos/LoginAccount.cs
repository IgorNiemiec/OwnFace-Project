using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FakeFacebook.Dtos
{
    public class LoginAccount
    {

        [Required]
        
        
        public string Email { get; set; }


        [Required]
        
        public string Password { get; set; }


     
    }


    



}
