using Exercicio_70_Vetores;
using System;
using System.Globalization;

namespace Vetores
{
    class program
    {
        static void Main(String[] args)
        {
            int x = int.Parse(Console.ReadLine());

            Product[] vect = new Product[x];

            for (int i = 0; i < x; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;
            for (int i = 0; i < x; i++)
            {
                sum += vect[i].Price;
            }
            // calculo da média
            double avg = sum / x;
            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}