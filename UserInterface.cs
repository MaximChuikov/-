using System;

namespace E
{
    static class UserInterface
    {
        public static void PrintUnderLines(int picks)
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < picks; i++)
            {
                if (i % 2 == 0)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Cyan;

                Console.Write('_');
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void PrintChar(char ch, int place)
        { 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(place, 0);
            Console.Write(ch);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void PrintAttemps(int attemps, int place)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(place, 0);
            Console.Write(attemps);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void GameResult(bool result, string word)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);

            if(result)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("YOU WIN");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"you lose, загаданное слово - ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(word);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void OfferNewGame()
        {
            Console.SetCursorPosition(0, 1);
            Console.Write("Нажмите пробел, чтобы начать новую игру.\nДля выхода нажмите любую клавишу");
        }
    }
}
