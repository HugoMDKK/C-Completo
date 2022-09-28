using System;
using System.Globalization;

namespace Exercício_40
{
    class Program
    {
        static void Main(String[] args)
        {
            Pessoas x, y;
            x = new Pessoas();
            y = new Pessoas();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            x.Name = Console.ReadLine();
            Console.Write("Idade: ");
            x.Year = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            y.Name = Console.ReadLine();
            Console.Write("Idade: ");
            y.Year = int.Parse(Console.ReadLine());

            if (x.Year > y.Year)
            {
                Console.WriteLine("Pessoa mais velha: " + x.Name);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + y.Name);
            }

        }
    }
}
