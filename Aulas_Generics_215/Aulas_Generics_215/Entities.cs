using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas_Generics_215
{
    internal class Entities
    {
        public string Name { get; set; };

        public double Price { get; set; };

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
