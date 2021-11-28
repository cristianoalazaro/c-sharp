﻿using tabuleiro;

namespace xadrez
{
    internal class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        public override string ToString()
        {
            return "T";
        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return p == null || p.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            //acima
            pos.DefinirValores(pos.Linha - 1, pos.Coluna);
            while(Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                    break;
                pos.Linha = pos.Linha - 1;
            }

            //abaixo
            pos.DefinirValores(pos.Linha + 1, pos.Coluna);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                    break;
                pos.Linha = pos.Linha + 1;
            }

            //Direita
            pos.DefinirValores(pos.Linha, pos.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                    break;
                pos.Coluna = pos.Coluna + 1;
            }

            //Esquerda
            pos.DefinirValores(pos.Linha, pos.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                    break;
                pos.Coluna = pos.Coluna - 1;
            }

            return mat;
        }

    }
}
