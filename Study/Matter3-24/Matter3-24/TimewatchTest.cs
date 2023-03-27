using System;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Matter3_24
{
    [MemoryDiagnoser]
    public class TimewatchTest
    {
        
        
        //[Benchmark]
        //public void TimeWatchString10()
        //{
        //    StringBuilder stringBuilder = new StringBuilder();
        //    string s =string.Empty;
        //    float time = 0;
        //    while (true)
        //    {
        //        time++;
        //        s += " "+time.ToString();
        //        if (time >= 10)
        //            return;
        //    }
        //}
        //[Benchmark]
        //public void TimeWatchStringBuilder10()
        //{
        //    StringBuilder stringBuilder = new StringBuilder();
        //    string s = string.Empty;
        //    float time = 0;
        //    while (true)
        //    {
        //        time++;
        //        stringBuilder.Append(" "+time);
        //        if (time >= 10)
        //            return;
        //    }
        //}

        [Benchmark]
        public void TimeWatchString10000()
        {
            StringBuilder stringBuilder = new StringBuilder();
            string s = string.Empty;
            float time = 0;
            while (true)
            {
                time++;
                s = " " + time.ToString();
                Console.WriteLine(s);
                if (time >= 10000)
                {
                    return;
                }
            }
           
        }
        [Benchmark]
        public void TimeWatchStringBuilder10000()
        {
            StringBuilder stringBuilder = new StringBuilder();
            string s = string.Empty;
            float time = 0;
            while (true)
            {
                time++;
                stringBuilder.Append(" " + time);
                Console.WriteLine(stringBuilder[(int)time -1]);
                if (time >= 10000)
                {
                    return;
                }
            }
           
        }
    }
}
