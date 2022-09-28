using System;
using System.Globalization;

namespace Exercicio_05_ER
{
    class Program
    {
        static void Main(String[] args)
        {
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}
