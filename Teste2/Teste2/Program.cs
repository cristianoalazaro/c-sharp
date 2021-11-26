using System;

namespace Teste2
{
    internal class Program
    {
        public Estados _estado { get; set; }

        public Program()
        {

        }

        public Program(Estados estado)
        {
            _estado = estado;
        }

        static void Main(string[] args)
        {
            //_estado.SetaEstado(1);
            Estados es = new Estados("development");
            Console.WriteLine(es.SetaEstado(1));
        }
    }
}
