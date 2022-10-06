using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio_Resolvido_140.Entities;
namespace course
{
    class Program
    {
        static void Main(String[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{1} data: ");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double ValuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additonalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, ValuePerHour, additonalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, ValuePerHour));
                }

                Console.WriteLine();
                Console.WriteLine("PAYMENTS: ");
                foreach(Employee emp in list)
                {
                    Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}