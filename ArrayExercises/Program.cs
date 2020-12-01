using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Arrays!");
            int[] nums = { 1, 1, 2, 3, 5, 8 };

            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    Console.WriteLine(nums[i]);
                }
            }
        }
    }
}
