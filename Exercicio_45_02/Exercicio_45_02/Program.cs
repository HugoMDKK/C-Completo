using Exercicio_45_02;
using System;
using System.Globalization;

namespace Exercicio_01
{
    class Program
    {
        static void Main(String[] args)
        {
            Funcionario func = new Funcionario();


            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + func.ToString());

            Console.WriteLine();
            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porcent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func);
        }
    }
}