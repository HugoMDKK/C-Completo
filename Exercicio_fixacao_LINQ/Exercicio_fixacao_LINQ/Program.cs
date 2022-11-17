using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio_fixacao_LINQ.Entities;
using System.IO;
using System.Linq;

namespace course
{
    class Program
    {
        static void Main(String[] args)
        {
            static void Print<T>(string message, IEnumerable<T> collection)
            {
                Console.WriteLine(message);
                foreach (T obj in collection)
                {
                    Console.WriteLine(obj);
                }
                Console.WriteLine();
            }

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();


            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    String[] fields = sr.ReadLine().Split(',');
                    String name = fields[0];
                    String email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    list.Add(new Employee(name, email, salary));
                }
            }

            Console.Write("Enter salary: ");
            double basicSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            var emails = list.Where(p => p.Salary > basicSalary).OrderBy(p => p.Email).Select(p => p.Email);
            Print("Email of people whose salary is more than 2000.00: ", emails);


            var r1 = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + r1);

        }
    }
}