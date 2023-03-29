using System;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Matter3_24
{
    class Program
    {
        static void Main(string[] args)
        {
            //Search s = new Search();
            //s.BinarySearch();
            BenchmarkRunner.Run<Search>();
            //BenchmarkRunner.Run<TimewatchTest>();

        }
    }
}
