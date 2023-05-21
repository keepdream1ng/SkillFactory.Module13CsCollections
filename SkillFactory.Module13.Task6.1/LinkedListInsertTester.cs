using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Module13.Task6_1
{
    public class LinkedListInsertTester
    {
        private  LinkedList<String> Lines = new LinkedList<string>();

        public void Run(string path)
        {
            Lines.Clear();
            using FileStream fs = new FileStream(path, FileMode.Open);
            using StreamReader sr = new StreamReader(fs);

            // Starting timer.
            var stopWatch = Stopwatch.StartNew();

            while (!sr.EndOfStream)
            {
                Lines.AddLast(sr.ReadLine());
            }

            // Timer result.
            Console.WriteLine($"Insert to the linked list is done in {stopWatch.Elapsed.TotalMilliseconds} milliseconds.");
            Lines.Clear();
        }
    }
}
