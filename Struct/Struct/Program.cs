using System;

namespace Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Point p;
            p.X = 10.5;
            p.Y = 6;

            double? x = null;
            double? y = 10.5;

            Console.WriteLine(p);
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);
            if (x.HasValue)
                Console.WriteLine(x.Value);
            Console.WriteLine(y.Value);*/

            double? x = null;
            double? y = 10;

            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
