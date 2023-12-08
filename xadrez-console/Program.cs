using System;
using tabuleiro;
using xadrez;
using xadrez_console;
using xadrez_console.tabuleiro;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));

                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 5));

                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(2, 5));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(2, 6));

                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}