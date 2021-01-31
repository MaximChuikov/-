using System;
using System.IO;

namespace E
{
    static class FileReader
    {
        private static string path = Path.Combine(Environment.CurrentDirectory, "words.txt");
        public static string[] words = File.ReadAllLines(path);
    }
}
