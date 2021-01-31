using System;
using System.Linq;

namespace E
{
    static class Game
    {
        public static int attemps { get; private set; }

        public static void NewGame()
        {
            Console.Clear();
            attemps = 5;
            var word = new MysteryWord();

            UserInterface.PrintUnderLines(word.HiddenWord.Length);
            UserInterface.PrintAttemps(attemps, word.HiddenWord.Length + 1);

            while(attemps != 0)
            {
                ConsoleKeyInfo ch = Console.ReadKey(true);

                if (!word.CheckTry(ch.KeyChar))
                {
                    attemps--;
                    UserInterface.PrintAttemps(attemps, word.HiddenWord.Length + 1);
                }

                if(!word.quessedChars.Contains(false))
                {
                    UserInterface.GameResult(true, word.HiddenWord);
                    break;
                }
            }
            if(attemps == 0)
                UserInterface.GameResult(false, word.HiddenWord);
        }
    }
}
