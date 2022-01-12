using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace K205_Examples
{
    public class User  // public, protected, private, internal, protected internal
    {
        public int Id;
        public string Name;
        public string Surname;
        public string Password;
        Product product;


        public string Hash()
        {

            var sha256 = SHA256.Create();

            var hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(Password));


            return BitConverter.ToString(hash).Replace("-", "");


        }
    }
}
