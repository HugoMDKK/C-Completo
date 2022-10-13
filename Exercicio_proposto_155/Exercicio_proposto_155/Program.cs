using Exercicio_proposto_155.Entities;
using Exercicio_proposto_155.Entities.Exceptions;
using System;
using System.Globalization;

namespace course
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string h = Console.ReadLine();
            Console.Write("Initial balance: ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double l = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(n, h, b, l);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                account.WithDraw(amount);
                Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch(DomainExceptions e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}
