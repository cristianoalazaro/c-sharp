using System;

namespace Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = Calculator.Sum(10, 20);
            int n2 = Calculator.Sum(10, 20, 30);
            int n3 = Calculator.Sum( 10, 20, 30, 55, 77 );
            int n4 = Calculator.Mult(10, 20);
            int n5 = Calculator.Mult(10, 20, 30);
            int n6 = Calculator.Mult(10, 20, 30, 40);
            int a = 10;
            Console.WriteLine(n1.ToString());
            Console.WriteLine(n2.ToString());
            Console.WriteLine(n3.ToString());
            Console.WriteLine(n4.ToString());
            Console.WriteLine(n5.ToString());
            Console.WriteLine(n6.ToString());
            Console.WriteLine(Calculator.Trip(a).ToString());
        }
    }
}
