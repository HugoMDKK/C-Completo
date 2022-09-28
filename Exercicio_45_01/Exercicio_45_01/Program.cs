using Exercicio_45_01;
using System.Globalization;

namespace Exercicio_01
{
    class Program
    {
        static void Main(String[] args)
        {
            Retangulo x = new Retangulo();


            Console.WriteLine("Entre a largura e altura do retângulo: ");
            x.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + x.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + x.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + x.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}