using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json
{
    internal class User
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public Address Endereco { get; set; }

        public string GetCode(string nome)
        {
            return Codigo.ToString();
        }

        public string GetName(int codigo)
        {
            return Nome;
        }

        public override string ToString()
        {
            return "Código: " + Codigo.ToString() + '\n' 
                 + "Nome: " + Nome + '\n' 
                 + "Rua: " + Endereco.Rua + '\n' 
                 + "Número: " + Endereco.Numero + '\n'
                 + "Bairro: " + Endereco.Bairro + "\n\n";
        }
    }
}
