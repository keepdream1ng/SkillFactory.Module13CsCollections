using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Module13.Task6_1
{
    public class ListInsertTester
    {
        private List<String> Lines = new List<string>();

        public void Run(string path)
        {
            Lines.Clear();
            using FileStream fs = new FileStream(path, FileMode.Open);
            using StreamReader sr = new StreamReader(fs);

            // Starting timer.
            var stopWatch = Stopwatch.StartNew();

            while (!sr.EndOfStream)
            {
                Lines.Add(sr.ReadLine());
            }

            // Timer result.
            Console.WriteLine($"Insert to the list is done in {stopWatch.Elapsed.TotalMilliseconds} milliseconds.");
            Lines.Clear();
        }
    }
}
