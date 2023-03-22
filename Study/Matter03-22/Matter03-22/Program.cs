using System;
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
    class Program
    {

        static void Main(string[] args)
        {
            //var summery = BenchmarkRunner.Run<test1>();
            //var summery1 = BenchmarkRunner.Run<ParseTest>();
            //var summery2 = BenchmarkRunner.Run<TryParseTest>();
            var summery3 = BenchmarkRunner.Run<MyParse>();
        }
    }
}
