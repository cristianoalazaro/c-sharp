using System;

namespace ArrayDeObjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto[] p = new Produto[3];

            p[0] = new Produto
            {
                Nome = "TV",
                Preco = 2699.00
            };

            p[1] = new Produto
            {
                Nome = "Radio",
                Preco = 299.99
            };

            p[2] = new Produto
            {
                Nome = "Computador",
                Preco = 3600.00
            };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(p[i]);
            };
        }
    }
}
