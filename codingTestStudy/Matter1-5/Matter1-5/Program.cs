using System;

namespace Matter1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            Console.WriteLine((double.Parse(nums[0]) / double.Parse(nums[1])));
        }
    }
}
