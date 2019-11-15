using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            bool x = true;



            while (x)
            {
                try
                {
                    Console.WriteLine("Input words: ");
                    word = Console.ReadLine();
                    if (FindShort(word) == 0)
                    {
                        Console.WriteLine("string is empty");

                    }
                    else
                        Console.WriteLine("The lenght of the shortest word is: " + FindShort(word));
                }

                catch (Exception ex)
                {
                    Console.WriteLine("incorect data");
                    //continue; 
                }


            }
        }
        public static int FindShort(string s)
        {
            var words = s.Split(' ');
            List<int> wordLengths = new List<int>();

            foreach (var word in words)
                wordLengths.Add(word.Length);

            wordLengths.Sort();

            return wordLengths[0];
        }

    }
}
