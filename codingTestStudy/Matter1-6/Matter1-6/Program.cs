using System;


namespace Matter1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int num1, num2;
            num1 = int.Parse(nums[0]);
            num2 = int.Parse(nums[1]);
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num1 % num2);
        }
    }
}
