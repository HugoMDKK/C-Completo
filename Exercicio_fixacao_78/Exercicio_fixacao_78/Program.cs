using Exercicio_fixacao_78;
using System.Globalization;

namespace course
{
    class Program
    {
        static void Main(String[] args)
        {


            List<Employees> list = new List<Employees>();

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Emplyoee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employees(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase :");
            int SearchId = int.Parse(Console.ReadLine());

            Employees emp = list.Find(x => x.Id == SearchId);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine();
            Console.WriteLine("Updated list of employess:");
            foreach(Employees obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}