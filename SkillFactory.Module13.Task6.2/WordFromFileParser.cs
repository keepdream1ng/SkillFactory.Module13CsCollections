using System.Diagnostics;

namespace SkillFactory.Module13.Task6_2
{
    public class WordFromFileParser
    {
        public RepeatWordsCounter Counter { get; private set; }
        private char[] separators = new char[] { ' ', '.', '\t', '\n', ';', ':', '!', '-', '?'};

        public WordFromFileParser(RepeatWordsCounter wordCouter)
        {
            Counter = wordCouter;
        }
        private void ParseWords(string input)
        {
            string[] tempWords = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            if (tempWords.Length != 0)
            {
                foreach (string word in tempWords)
                {
                    Counter.Add(word);
                }
            }
        }

        public void ParseFromFile(string path)
        {
            using FileStream fs = new FileStream(path, FileMode.Open);
            using StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                ParseWords(sr.ReadLine());
            }
        }
    }
}
