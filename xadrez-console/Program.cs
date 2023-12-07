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
                PosicaoXadrez pos = new PosicaoXadrez('c', 7);

                Console.WriteLine(pos);

                Console.WriteLine(pos.toPosicao());
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}