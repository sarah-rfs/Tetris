using System;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            MainMenu.writeTitle();
            

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Aperte Enter para começar");
            Console.WriteLine("As setas movem para a direita e para a esquerda");
            Console.WriteLine("A tecla espaço rotaciona a peça");
            Console.WriteLine("Aperte esc para sair");
            Console.ReadKey(true);
        }
    }
}
