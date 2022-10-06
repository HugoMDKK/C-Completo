using System.Globalization;

namespace Exercicio_proposto_141.Entities
{
    internal class Product
    {
        public String Name { get; set; }
        public double Price { get; set; }


        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name
                + " $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}


