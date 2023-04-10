using System;

namespace SolutionNote
{
    class Program
    {
        // x,y 좌표의 각 최대 최소 값을 구하여 넓이를 구한다.
        static void Main(string[] args)
        {
            int[] lengths = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int max=0;
            int j = 0;
            int[] otherLength = new int[2];
            for(int i =0; i<3; i++)
            {
               
                if(max < lengths[i])
                {
                    if(max != 0)
                    {
                        otherLength[j] = max;
                        j++;
                        max = lengths[i];
                    }
                    max = lengths[i];
                }
                else
                {   
                    otherLength[j] = lengths[i];
                    j++;
                }
            }
            if(max < otherLength[0] + otherLength[1])
            {
                Console.WriteLine(otherLength[0] + otherLength[1] + max);
            }
            else
            {
                Console.WriteLine(otherLength[0] + otherLength[1] + (otherLength[0] + otherLength[1] - 1));
            }
        }
    }
}

