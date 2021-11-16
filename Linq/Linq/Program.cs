using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 1, 2, 3, 4, 5 };

            IEnumerable<int> result = n
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            foreach(int x in result)
            {
                Console.WriteLine(x.ToString());
            }
        }
    }
}
