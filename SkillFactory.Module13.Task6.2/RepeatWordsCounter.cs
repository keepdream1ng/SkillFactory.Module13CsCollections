using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Module13.Task6_2
{
    public class RepeatWordsCounter
    {
        public Dictionary<string, int> Words { get; private set; }

        public RepeatWordsCounter()
        {
            Words = new Dictionary<string, int>();
        }

        public void Add(string word)
        {
            if (Words.ContainsKey(word))
            {
                Words[word]++;
            } else
            {
                Words.Add(word, 1);
            }
        }

    }
}
