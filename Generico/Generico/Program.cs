using System;

namespace Generico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintService<string> printService = new PrintService<string>();
            Console.WriteLine("How many values?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                //int x = int.Parse(Console.ReadLine());
                //printService.AddValue(x);
                string text = Console.ReadLine();
                printService.AddValue(text);
            }

            printService.Print();
            printService.First();
        }
    }
}
