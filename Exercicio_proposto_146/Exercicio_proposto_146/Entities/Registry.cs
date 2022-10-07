

namespace Exercicio_proposto_146.Entities
{
    abstract class Registry
    {
        public string Name { get; set; }
        public double Income { get; set; }


        public Registry()
        {

        }

        protected Registry(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double TotalTaxes();


    }
}
