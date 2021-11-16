using System;

namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = new string[] { "Cristiano", "Elenice", "Cristiane", "Bruno" };

            foreach(string obj in vetor)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
