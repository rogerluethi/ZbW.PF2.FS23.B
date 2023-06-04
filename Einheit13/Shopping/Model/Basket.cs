using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einheit13.Shopping.Model
{
    internal class Basket
    {
        public Basket()
        {
            Products = new List<Product>();
        }

        public List<Product> Products { get; set; }

    }
}
