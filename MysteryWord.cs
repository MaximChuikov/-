using System;

namespace E
{
    class MysteryWord
    {
        public readonly string HiddenWord;
        public bool[] quessedChars;
        public MysteryWord()            //конструктор класса
        {
            Random rand = new Random();
            HiddenWord = FileReader.words[rand.Next(FileReader.words.Length)];
            quessedChars = new bool[HiddenWord.Length];
        }
        public bool CheckTry(char ch)
        {
            bool answer = false;
            for (int i = 0; i < HiddenWord.Length; i++)
            {
                if(HiddenWord[i] == ch)
                {
                    answer = true;
                    quessedChars[i] = true;
                    UserInterface.PrintChar(ch, i);
                }
            }
            return answer;
        }
    }
}
