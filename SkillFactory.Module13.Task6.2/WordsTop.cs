namespace SkillFactory.Module13.Task6_2
{
    public class WordsTop
    {
        public int ListLenght { get; }
        public LinkedList<(int count, string word)> ListOfMostUsedWords { get; private set; }
        private int LowestCount
        {
            get
            {
                if (ListOfMostUsedWords.Last == null)
                {
                    return 0;
                } else
                {
                    return ListOfMostUsedWords.Last.Value.count;
                }
            }
        }

        public WordsTop(int lenght)
        {
            ListLenght = lenght;
            ListOfMostUsedWords = new LinkedList<(int count, string word)>();
        }

        private void AddToTop(int newCount, string newWord)
        {
            if (ListOfMostUsedWords.Count == 0)
            {
                ListOfMostUsedWords.AddLast((newCount, newWord));
            }
            else
            {
                // Incert sort while adding nodes to the list.
                var nodeWithSmallerCount = ListOfMostUsedWords.Last;
                while ((nodeWithSmallerCount.Previous != null) && (nodeWithSmallerCount.Previous.Value.count < newCount))
                {
                    nodeWithSmallerCount = nodeWithSmallerCount.Previous;
                }
                ListOfMostUsedWords.AddBefore(nodeWithSmallerCount, (newCount, newWord));
                // Keeping list tide.
                if (ListOfMostUsedWords.Count > ListLenght)
                {
                    ListOfMostUsedWords.RemoveLast();
                }
            }
        }

        public void GetTopUsed(RepeatWordsCounter counter)
        {
            ListOfMostUsedWords.Clear();
            foreach (var item in counter.Words)
            {
                if (item.Value > LowestCount)
                {
                    AddToTop(item.Value, item.Key);
                }
            }
            foreach (var node in ListOfMostUsedWords)
            {
                Console.WriteLine($"{node.count, -15} {node.word, 15}");
            }
        }
    }
}
