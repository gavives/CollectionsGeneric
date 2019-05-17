using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T>
            List<Games> games = new List<Games>();
            games.Add(new Games() { GameName = "Apex Legends" });
            games.Add(new Games() { GameName = "Modern Warfare 2" });
            games.Add(new Games() { GameName = "Black Ops 4" });
            games.Add(new Games() { GameName = "Halo Reach" });
            games.Add(new Games() { GameName = "Halo 2" });
            games.Add(new Games() { GameName = "Call of Duty 4" });

            Console.WriteLine();
            foreach (Games GameName in games)
            {
                Console.WriteLine(GameName);
            }


            //LinkedList<T>
            string[] words = { "Apex", "is", "the", "best", "game", "ever" };
            LinkedList<string> sentence = new LinkedList<string>(words);
            Display(sentence, "The linked list values:");
            Console.WriteLine("sentence.Contains(\"best\") = {0}",
                sentence.Contains("best"));


            //Queue<T>
            Queue<string> numbers = new Queue<string>();
            numbers.Enqueue("one");
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
            numbers.Enqueue("five");

            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            } 


            //Stack
           Stack <string> numbers2 = new Stack<string>();
            numbers2.Push("one");
            numbers2.Push("two");
            numbers2.Push("three");
            numbers2.Push("four");
            numbers2.Push("five");

            foreach (string number in numbers2)
            {
                Console.WriteLine(numbers2);
            }

            //Dictionary<TKey, TValue>
            Dictionary<string, string> openWith =
            new Dictionary<string, string>();

            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with Key = \"txt\" already exists.");
            }


            //SortedList<TKey, TValue>
            SortedList<string, string> openWith2 = new SortedList<string, string>();
            
            openWith2.Add("txt", "notepad.exe");
            openWith2.Add("bmp", "paint.exe");
            openWith2.Add("dib", "paint.exe");
            openWith2.Add("rtf", "wordpad.exe");

            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with Key = \"txt\" already exists.");
            }


            //HashSet<T>)
            HashSet<int> evenNumbers = new HashSet<int>();
            HashSet<int> oddNumbers = new HashSet<int>();

            for (int i = 0; i < 5; i++)
            {
                
                evenNumbers.Add(i * 2);

                
                oddNumbers.Add((i * 2) + 1);
            }
        }

        private static void Display(LinkedList<string> sentence, string v)
        {
            throw new NotImplementedException();
        }
    }
}
