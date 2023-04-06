using System;
using System.IO;
using System.Text;

namespace SolutionNote
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // 출력과 입력을 최적화 하기위한 객체 미리 생성
            StreamReader reader = new StreamReader(Console.OpenStandardInput());
            StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());
            int count =int.Parse(reader.ReadLine());
            int line = 0;
            int end = 0;
            int different = 0;

            while(count > end)
            {
                line += 1;
                end += line;
            }
            different = end - count;
            if (line % 2 == 0)// 짝수 라인
                writer.WriteLine((line - different) + "/" + (different + 1));
            else
                writer.WriteLine((different + 1) + "/" + (line - different));
            writer.Close();
            reader.Close();
        }
       
    }
}

