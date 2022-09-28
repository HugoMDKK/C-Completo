using Exercicio_45_03;
using System;
using System.Globalization;

namespace Exercicio_01
{
    class Program
    {
        static void Main(String[] args)
        {
           Student stu = new Student();

            Console.Write("Nome do aluno: ");
            stu.Name = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            stu.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            stu.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            stu.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + stu.OverallNote().ToString("F2", CultureInfo.InvariantCulture));
            
            if (stu.Approved())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + stu.RemainingNote().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}
