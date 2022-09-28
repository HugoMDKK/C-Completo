using System;
using System.Globalization;

namespace Teste_02
{
    class Program
    {
        static void Main(String[] strings)
        {
            double raio, area;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = 3.14159 * (raio * raio);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}