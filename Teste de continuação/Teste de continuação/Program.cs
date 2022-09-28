using System.Globalization;

namespace Teste_C
{
    class Program
    {
        static void Main(String[] args)
        {
            int codigo1, codigo2, numeroDePecas1, numeroDePecas2;
            double valor1, valor2;

            double valorTotal1 = 0.0;
            String[] vet = Console.ReadLine().Split(' ');
            codigo1 = int.Parse(vet[0]);
            numeroDePecas1 = int.Parse(vet[1]);
            valor1 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            if (numeroDePecas1 > 0.0)
            {
                valorTotal1 = numeroDePecas1 * valor1;
            }

            double valorTotal2 = 0.0;
            String[] vet1 = Console.ReadLine().Split(' ');
            codigo2 = int.Parse(vet1[0]);
            numeroDePecas2 = int.Parse(vet1[1]);
            valor2 = double.Parse(vet1[2], CultureInfo.InvariantCulture);
            if (numeroDePecas2 > 0.0)
            {
                valorTotal2 = numeroDePecas2 * valor2;
            }

            Double valorGeral;
            valorGeral = valorTotal1 + valorTotal2;

            Console.WriteLine("VALOR A PAGAR: " + valorGeral.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
