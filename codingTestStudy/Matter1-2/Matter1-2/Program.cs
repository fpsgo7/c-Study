using System;

namespace Matter1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] nums = Console.ReadLine().Split();
            int num1, num2;
            num1 = int.Parse(nums[0]);
            num2 = int.Parse(nums[1]);
            Console.WriteLine((num1+num2).ToString());
        }
    }
}
