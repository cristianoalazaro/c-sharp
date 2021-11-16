using System;
using System.Collections.Generic;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            List<string> nomes = new List<string>
            {
                "Cristiano",
                "Elenice",
                "Cristiane",
                "Bruno"
            };

            nomes.Add("Mel");
            nomes.Add("Dingo");
            nomes.Insert(3, "Carro");

            foreach(string obj in nomes)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine(nomes.Count);

            string s1 = nomes.Find(x => x[0] == 'E');

            Console.WriteLine("First E: " + s1);

            string s2 = nomes.FindLast(x => x[0] == 'C');

            Console.WriteLine(s2);

            int pos1 = nomes.FindIndex(x => x[0] == 'E');
            int pos2 = nomes.FindLastIndex(x => x[0] == 'C');

            Console.WriteLine(pos1.ToString());
            Console.WriteLine(pos2.ToString());

            List<string> nomes2 = nomes.FindAll(x => x[0] == 'C');

            foreach(string obj in nomes2)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
