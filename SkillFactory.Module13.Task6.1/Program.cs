using SkillFactory.Module13.Task6_1;

namespace SkillFactory.Module13Task6_1
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

                Console.WriteLine("Press 1, to test incert for List<T>, or press 2 to test for LinkedList<T>");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        {
                            ListInsertTester ListTest = new();
                            ListTest.Run(inputPath);    
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            LinkedListInsertTester LinkedListTest = new();
                            LinkedListTest.Run(inputPath);
                            break;
                        }
                    default:
                        {
                            throw new Exception("Invalid input");
                        }
                }
            }
            catch(StackOverflowException)
            {
                Console.WriteLine("File may be too big...");
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("Cant find the file by the path");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Test ended, press any key to exit.");
                Console.ReadKey(true);
            }
        }
    }
}