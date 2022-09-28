using System.Globalization;

namespace Teste_03
{
    class Program
    {
        static void Main(String[] args)
        {
            double A, B, C;

            string[] vet = Console.ReadLine().Split(' ');

            
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double delta = 0.0;
            double X1 = 0.0;
            double X2 = 0.0;
            if (A == 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else if (A > 0.0)
            {
                delta = (B * B) - (4 * A * C);                
            }
            if ( delta < 0.0)
            {
                Console.WriteLine("Impossivel calcular ");
            } 
            else if (delta > 0.0)
            {
                double raiz = Math.Sqrt(delta);
                X1 = ((-(B)) + raiz) / (2 * A);
                X2 = ((-(B)) - raiz) / (2 * A);

                Console.WriteLine("X1 = " + X1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("X2 = " + X2.ToString("F5", CultureInfo.InvariantCulture));
            }            
        }
    }
}