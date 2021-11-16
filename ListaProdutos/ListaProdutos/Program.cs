using System;

namespace ListaProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Entre com a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produto = new(nome, preco, quantidade);
            Produto produto2 = new("", 100.00);
            /*Produto produto3 = new Produto
            {
                Nome() = "Carro",
                Preco = 1500.15,
                Quantidade = 15
            };*/

            /*Console.WriteLine("Os dados do produto são: " + produto.Nome + " - $" + produto.Preco + " - " +
                produto.Quantidade);*/
            Console.WriteLine(produto);
            Console.WriteLine("Valor em estoque: " + produto.ValorTotalEmEstoque().ToString());
            Console.WriteLine(produto2);
            Console.WriteLine("Valor em estoque: " + produto2.ValorTotalEmEstoque().ToString());
            //Console.WriteLine(produto3);
            //Console.WriteLine("Valor em estoque: " + produto3.ValorTotalEmEstoque().ToString("F2"));
            Console.WriteLine(produto.Nome);
            Console.ReadLine();
        }
    }
}
