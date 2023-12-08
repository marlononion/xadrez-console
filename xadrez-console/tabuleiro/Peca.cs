using tabuleiro;

namespace xadrez_console.tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; set; }
        public Tabuleiro tabuleiro { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.qteMovimentos = 0;
            this.tabuleiro = tabuleiro;
        }

        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
