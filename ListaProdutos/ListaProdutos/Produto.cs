using System;
using System.Globalization;

namespace ListaProdutos
{
    class Produto
    {
        public string _nome;
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        /*public Produto(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }*/

        public Produto() { }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            this.Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
        }

        /*public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 0)
                _nome = nome;
        }*/

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 0)
                    _nome = value;
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return Nome
                   + ", $"
                   + Preco.ToString("F2", CultureInfo.InvariantCulture)
                   + ", "
                   + Quantidade
                   + " unidades.";
        }
    }
}
