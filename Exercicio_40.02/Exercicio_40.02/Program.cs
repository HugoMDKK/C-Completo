using Exercicio_40._02;
using System;
using System.Globalization;

namespace Exercicio_40_02
{
    class Program
    {
        static void Main(String[] args)
        {
            Funcionarios x, y;
            x = new Funcionarios();
            y = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            x.Name = Console.ReadLine();
            Console.Write("Salário: ");
            x.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            y.Name = Console.ReadLine();
            Console.Write("Salário: ");
            y.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double AverageSalary = (x.Salary + y.Salary) / 2;

            Console.WriteLine("Salário Médio = " + AverageSalary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
