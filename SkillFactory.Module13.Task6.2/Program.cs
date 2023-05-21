using SkillFactory.Module13.Task6_2;
using System.Diagnostics;

namespace SkillFactory.Module13Task6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? inputPath;
            if (args.Length == 0)
            {
                Console.WriteLine("Insert path to the text file for testing or use it as an argument next time you run programm.");
                inputPath = Console.ReadLine();
            }
            // In case we suppose to use arguments.
            else
            {
                inputPath = args[0];
            }

            try
            {
                if (!File.Exists(inputPath))
                {
                    throw new FileNotFoundException();
                }

                RepeatWordsCounter counter = new RepeatWordsCounter();
                WordFromFileParser parser = new WordFromFileParser(counter);
                parser.ParseFromFile(inputPath);

                Console.WriteLine(counter.Words.Count);
            }
            catch (StackOverflowException)
            {
                Console.WriteLine("File may be too big...");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Cant find the file by the path");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Calculation ended, press any key to exit.");
                Console.ReadKey(true);
            }
        }
    }
}