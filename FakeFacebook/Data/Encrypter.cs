using FakeFacebook.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeFacebook.Data
{
    public class Encrypter
    {

        private AccountContext _context;

        public Encrypter(AccountContext context)
        {
            _context = context;
        }



        public void EncryptAllPasswords()
        {

            IEnumerable<string> Passwords = _context.Account.Select(x => x.Password).ToList();
           

             foreach(var a in Passwords)
            {

                byte[] s = System.Text.ASCIIEncoding.ASCII.GetBytes(a);

                string Encrypt = Convert.ToBase64String(s);

                _context.Add(Encrypt);

            }

            
            



        }






    }
}
