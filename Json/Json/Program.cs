using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = null;
            using (StreamReader stream = new StreamReader(@"D:\Projetos\TreinoCSharp\Json\Json\User.json"))
            {
                string jsonString = stream.ReadToEnd();
                users = JsonConvert.DeserializeObject<List<User>>(jsonString);

                foreach(User u in users)
                {
                    Console.WriteLine(u);
                }

                void GetName(int codigo)
                {
                    var n = users.FindLast(p => p.Codigo == codigo);
                    Console.WriteLine(n.GetName(codigo));
                }

                void GetCode(string nome)
                {
                    User n = users.FindLast(p => p.Nome == nome);
                    Console.WriteLine(n.GetCode(nome));
                }

                GetCode("Bertano");
                GetName(2);
            }
        }
    }
}
