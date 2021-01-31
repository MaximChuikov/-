using System;

namespace E
{

    class Program
    {
        static void Main()
        {
            Console.CursorVisible = false;

            ConsoleKeyInfo key;
            for(; ; )
            {
                Game.NewGame();
                UserInterface.OfferNewGame();
                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Spacebar)
                    break;
            }
        }
    }
}
