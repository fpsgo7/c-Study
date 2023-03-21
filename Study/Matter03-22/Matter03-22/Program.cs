using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Matter03_22
{
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
    class Program
    {

        static void Main(string[] args)
        {
            var summery = BenchmarkRunner.Run<test1>();
        }
    }
}
