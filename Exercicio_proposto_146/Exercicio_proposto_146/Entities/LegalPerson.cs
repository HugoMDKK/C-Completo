namespace Exercicio_proposto_146.Entities
{
    class LegalPerson : Registry
    {

        public int NumberEmployees { get; set; }

        public LegalPerson()
        {

        }

        public LegalPerson(int numberEmployees, string Name, double Income) : base(Name, Income)
        {
            NumberEmployees = numberEmployees;
        }

        public override double TotalTaxes()
        {
            if (NumberEmployees > 10)
            {
                return Income * 0.14;
            }
            else
            {
                return Income * 0.16;
            }
        }

    }
}
