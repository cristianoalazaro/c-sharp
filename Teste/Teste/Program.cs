using System;
using System.Collections.Generic;

namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> dic = new Dictionary<int,string>();
            KeyValuePair<int,string> s = PreencheDic();
            dic.Add(PreencheDic().Key,PreencheDic().Value);
            //Console.WriteLine(s.Value);
        }

        public static KeyValuePair<int, string> PreencheDic()
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Teste");
            return d;
        }

    }
}
