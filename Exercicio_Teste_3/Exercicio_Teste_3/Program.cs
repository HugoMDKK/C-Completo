using System.Globalization;

namespace Teste_03
{
    class Program
    {
        static void Main(String[] args)
        {

            String[] vet = Console.ReadLine().Split(' ');

            int C = int.Parse(vet[0]);
            int Q = int.Parse(vet[1]);

            double X = 0.0;
            // Valor do Cachorro quente
            if (C == 1)
            {
                X = Q * 4.00;
            }
            // Valor do X - Salada  
            else if (C == 2)
            {
                X = Q * 4.50;
            }
            // Valor do X - Bacon  
            else if (C == 3)
            {

                X = Q * 5.00;
            }
            // Valor do Torrada Simples 
            else if (C == 4)
            {
                X = Q * 2.00;
            }
            // Valor do Refrigerante 
            else
            {
                X = Q * 1.50;
            }
            Console.WriteLine("Total: R$ " + X.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}