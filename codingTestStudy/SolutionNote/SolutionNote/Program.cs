using System;
using System.Collections.Generic;

namespace SolutionNote
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int[] twoNums = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int[] numsArray  = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int correctNum = twoNums[1];
            List<int> haps = new List<int>();
            int hap=0;
            int count=0;

            for(int i =0; i< numsArray.Length-2; i++)
            {
                haps.Add(numsArray[i]);
            }
            foreach (int a in haps)
            {
                Console.WriteLine(a);
            }
        }
    }
}

