using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    internal class Calculator
    {
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static int Mult(params int[] numbers)
        {
            int mult = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                mult *= numbers[i];
            }
            return mult;
        }

        public static int Trip (int x)
        {
            return x * 3;
        }
    }
}
