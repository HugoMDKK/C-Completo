using System;
using System.Globalization;

namespace Aula_57_AltoProperties
{
    class program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);

        }
    }
}