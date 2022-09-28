using System;
using System.Globalization;

namespace Exercicio_06
{
    class Program
    {
        static void Main(String[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] vet = new int[N];


            int I = 0;
            int O = 0;
            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());
                if (vet[i] >= 10 && vet[i] <= 20) {
                    I = I + 1;
                } else
                {
                    O = O + 1;
                }
            }
            Console.WriteLine(I + " in");
            Console.WriteLine(O + " out");
        }
    }
}