using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lists!");
            List<int> numbers = new List<int>() {1,2,3,4,5,6,7,8,9,10};
            Program.FindSum(numbers);

            List<string> words = new List<string> { "lorem", "ipsum", "dolor", "sit", "amet", "adipiscing", "labore", "ut" };
            Console.WriteLine("Enter length of word:");
            int len = int.Parse(Console.ReadLine());
            Program.FindWord(words, len);
              
        }
        static int FindSum(List<int> num)
        {
            int sum = 0;
            for (int i = 0; i < num.Count; i++)
            {
                if (num[i] % 2 == 0)
                {
                    sum += num[i];
                }
            }
            return sum;
        }
        static void FindWord(List<string> list, int len)
        {
           for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Length == len)
                {
                    Console.WriteLine(list[i]);
                } 
                else
                {
                    Console.WriteLine("No word matches the length entered.");
                    break;
                }
            }
        }
    }
}
