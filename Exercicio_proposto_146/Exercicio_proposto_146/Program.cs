using Exercicio_proposto_146.Entities;
using System.Globalization;
using System.Collections.Generic;
using System.Xml.Schema;

namespace course
{
    class Program
    {
        static void Main(String[] args)
        {
            List<Registry> list = new List<Registry>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PhysicalPerson(health, name, income));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new LegalPerson(employees, name, income));
                }
            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (Registry rg in list)
            {
                double totaltaxes = rg.TotalTaxes();
                Console.WriteLine(rg.Name + ": $ " + totaltaxes.ToString("F2", CultureInfo.InvariantCulture));
                sum += totaltaxes;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}