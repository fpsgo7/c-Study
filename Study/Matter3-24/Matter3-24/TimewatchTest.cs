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
        //|----------------------------- |---------:|----------:|----------:|---------:|-------:|----------:|
        //|         TimeWatchString10000 | 2.578 ms | 0.0143 ms | 0.0127 ms | 132.8125 |      - | 624.33 KB |
        //| TimeWatchStringBuilder10000A | 3.292 ms | 0.0553 ms | 0.0700 ms |  82.0313 | 3.9063 | 384.02 KB |
        //| TimeWatchStringBuilder10000B | 2.352 ms | 0.0039 ms | 0.0031 ms |  50.7813 |      - | 234.48 KB |
        //| TimeWatchStringBuilder10000C | 2.349 ms | 0.0220 ms | 0.0206 ms |  78.1250 | 7.8125 |  377.8 KB |

        [Benchmark]
        public void TimeWatchString10000()
        {
            StringBuilder stringBuilder = new StringBuilder();
            string s = string.Empty;
            float time = 0;
            while (true)
            {
                time++;
                s = string.Format("{0:00.00}", time);
                if (time >= 10000)
                {
                    return;
                }
            }
           
        }
        [Benchmark]
        public void TimeWatchStringBuilder10000A()
        {
            StringBuilder stringBuilder = new StringBuilder();
            string s = string.Empty;
            float time = 0;
            while (true)
            {
                time++;
                stringBuilder.AppendFormat("{0:00.00}", time);
                stringBuilder.Remove(0, 5);
                if (time >= 10000)
                {
                    return;
                }
            }
           
        }
        [Benchmark]
        public void TimeWatchStringBuilder10000B()
        {
            StringBuilder stringBuilder = new StringBuilder();
            string s = string.Empty;
            float time = 0;
            while (true)
            {
                time++;
                stringBuilder.AppendFormat("{0:00.00}", time);
                stringBuilder.Clear();
                if (time >= 10000)
                {
                    return;
                }
            }

        }
        [Benchmark]
        public void TimeWatchStringBuilder10000C()
        {
            StringBuilder stringBuilder = new StringBuilder();
            string s = string.Empty;
            float time = 0;
            while (true)
            {
                time++;
                stringBuilder.AppendFormat("{0:00.00}", time);
                if (time >= 10000)
                {
                    return;
                }
            }

        }
    }
}
