using System;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Matter03_22
{
    //Summary의 Method 컬럼은 측정한 method name이다.
    //Mean : 측정값의 평균
    //Error : 99.9%의 신뢰도 구간의 절반. 
    //StdDev : 표준편차
    [MemoryDiagnoser]
    public class test1
    {
        int a = 1;
        int b = 2;
        [Benchmark]
        public int hello()
        {
            return a + b;
        }
    }
    [MemoryDiagnoser]
    public class ParseTest
    {
        //결과
        // Mean 13.30. 
        //Error 0.037
        //StdDev 0.033
        string s = "123";
        int a = 0;
        [Benchmark]
        public int ParseStart()
        {
            a= int.Parse(s);
            return a;
        }
    }
    [MemoryDiagnoser]
    public class TryParseTest
    {
        //결과
        // Mean 11.64 
        //Error 0.045
        //StdDev 0.038
        string s = "123";
        int a = 0;
        bool b;
        [Benchmark]
        public int TryParseStart()
        {
            b = int.TryParse(s, out a);
            return a;
        }
    }
    [MemoryDiagnoser]
    public class MyParse
    {
        //결과
        // Mean 3.140. 
        //Error 0.0111
        //StdDev 0.099
        [Benchmark]
        public int MyParseStart()
        {
            string s = "123";
            int a = 0;

            for (int i=0; i < s.Length; i++)
            {
                int b = s[i];
                for(int j = 0; j < s.Length - i -1; j++)
                {
                    b *= 10;
                }
                a += b;
            }
            return a;
        }
    }
    [MemoryDiagnoser]
    public class UseSplit
    {
        //결과
        // Mean 58.22
        //Error  0.327
        //StdDev 0.306
        [Benchmark]
        public string UseSplitStart()
        {
            string text1 = "Happy BirthDay";

            string[] texts = text1.Split();

            return texts[0];
            
        }
    }
    [MemoryDiagnoser]
    public class MySplit
    {
        //결과
        // Mean 
        //Error  
        //StdDev 
        [Benchmark]
        public string UseMySplitStart()
        {
            string text1 = "Happy BirthDay";
            string[] texts;
            int textsCount = 0;
            int arryCount = 0;
            for (int i = 0; i < text1.Length; i++)
            {
                if (text1[i].Equals(' '))
                {
                    arryCount++;
                }
            }
            if (arryCount > 0)
            {
                texts = new string[arryCount + 1];
                for (int i = 0; i < text1.Length; i++)
                {
                    texts[textsCount] += text1[i];
                    if (text1[i].Equals(' '))
                    {
                        textsCount++;
                    }
                }
            }
            else
            {
                texts = new string[1];
            }
            return texts[0];
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            //var summery = BenchmarkRunner.Run<test1>();
            //var summery1 = BenchmarkRunner.Run<ParseTest>();
            //var summery2 = BenchmarkRunner.Run<TryParseTest>();
            //var summery3 = BenchmarkRunner.Run<MyParse>();
            //var summery3 = BenchmarkRunner.Run<UseSplit>();
            var summery3 = BenchmarkRunner.Run<MySplit>();
        }
    }
}
