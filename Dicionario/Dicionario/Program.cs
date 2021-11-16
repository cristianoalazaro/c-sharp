using System;
using System.Collections.Generic;

namespace Dicionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();
            cookies["user"] = "Cristiano";
            cookies["email"] = "cristianoalazaro@hotmail.com";

            Console.WriteLine(cookies["user"]);
        }
    }
}
