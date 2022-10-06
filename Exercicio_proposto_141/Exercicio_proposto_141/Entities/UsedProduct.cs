using System.Globalization;

namespace Exercicio_proposto_141.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manuFactureDate) : base(name, price)
        {
            ManufactureDate = manuFactureDate;
        }

        public override string PriceTag()
        {
            return Name
                + " (used) $ "               
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + ManufactureDate.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
