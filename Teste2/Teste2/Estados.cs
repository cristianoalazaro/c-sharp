using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste2
{
    internal class Estados
    {
        public string _env { get; set; }

        public Estados()
        {

        }

        public Estados(string env)
        {
            _env = env;
        }

        public enum Uf : int
        {
            SaoPaulo,
            Parana,
            RioDeJaneiro
        }

        public string SetaEstado(int uf)
        {
            return "ok";
        }
    }
}
