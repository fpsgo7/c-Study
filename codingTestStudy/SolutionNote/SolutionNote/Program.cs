using System;
using System.Linq;

namespace SolutionNote
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int count = s.Count(e=>e!="");
            Console.WriteLine(count);
        }
    }
}
