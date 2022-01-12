using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K205_Examples
{
    public class Product // OOP SOLID MVC
    {
        

        public int Id;
        public string Name;
        public string Description;
        public decimal Price;

        public decimal EDV()
        {
            decimal result = Price * 18 / 100 + Price;

            return result;
        }

        public string SEO()
        {
            var seo = Name.ToLower().Replace(" ", "-")
                  .Replace("ə", "e")
                  .Replace("ğ", "g")
                  .Replace("ç", "c");

            return seo;
        }
    }

    
}
