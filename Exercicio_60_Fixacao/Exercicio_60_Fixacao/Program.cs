using System;
using System.Globalization;

namespace Exercicio_60_Fixacao
{
    class Program
    {
        static void Main(String[] args)
        {
            Conta contaBancaria;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaBancaria = new Conta(numero, titular, depositoInicial);
            }
            else {
                contaBancaria = new Conta(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(contaBancaria);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Deposito(dep);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double retirar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Saque(retirar);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria);

        }
    }
}
