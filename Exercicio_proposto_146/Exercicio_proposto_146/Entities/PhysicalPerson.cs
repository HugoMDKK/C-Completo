using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_proposto_146.Entities
{
     class PhysicalPerson : Registry
    {
        public double HealthExpenses { get; set; }


        public PhysicalPerson()
        {

        }

        public PhysicalPerson(double healthExpenses, string Name, double Income) : base(Name, Income)
        {
            HealthExpenses = healthExpenses;
        }

        public override double TotalTaxes()
        {
            if (Income <= 20.000)
            {
                return (Income * 0.15) - (HealthExpenses * 0.5); 
            }
            else
            {
                return (Income * 0.25) - (HealthExpenses * 0.5);
            }
        }
    }
}
