using System;
using System.Threading;

namespace ThreadStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            //쓰레드 실행들
            //쓰레드 실행1 기본
            //Thread thread = new Thread(Run);
            //thread.Start();

            ////쓰레드 실행2
            //Thread thread1 = new Thread(new ThreadStart(Run));
            //thread1.Start();

            ////쓰레드 실행3
            //Thread thread2 = new Thread(
            //        delegate ()
            //        {
            //            Run();
            //        }
            //    );

            ////쓰레드 실행 4
            //Thread thread3 = new Thread(() => Run());
            //thread3.Start();

            ////쓰레드 실행 #5
            //new Thread(() => Run()).Start();

            //함수 쓰레드 실행 1
            //AnyJob anyJob = new AnyJob();
            //Thread thread6 = new Thread(anyJob.ThreadJob);
            //thread6.Start();

            //// 매계변수 있는 함수 스레드 실행2
            //Thread thread7 = new Thread(anyJob.RunMethod);
            //thread7.Start(15);

            //// 매계변수 있는 함수 스레드 실행3
            //Thread thread8 = new Thread(Param.RunMethod);
            //thread8.Start(new Param(5, (float)10.3));

            //쓰레드 종료 기다리기1
            void RunMethod1(object obj)
            {
                int value1 = (int)obj;
                for (int i = 0; i < value1; i++)
                {
                    Console.WriteLine(i + " / " + value1);
                    Thread.Sleep(100);// 해당 초만큼 쉬게 하여 규칙적으로 움직이게함
                }
                Console.WriteLine("RunMethod finished !");
            }
            Thread thread9 = new Thread(RunMethod1);
            thread9.Start(15);
            thread9.Join();
            Console.WriteLine("Atfer finishing RunMethod() !");
            EventWaitHandle ewh = new EventWaitHandle(false, EventResetMode.ManualReset);
            
            ////쓰레드 종료 기다리기2
            //void RunMethod2(object obj)
            //{
            //    int value1 = (int)obj;
            //    for (int i = 0; i < value1; i++)
            //    {
            //        Console.WriteLine(i + " / " + value1);
            //        Thread.Sleep(100);
            //    }
            //    Console.WriteLine("RunMethod finished !");
            //    ewh.Set();
            //}
            //Thread thread10 = new Thread(RunMethod2);
            //thread10.Start(15);
            //// thread.Join();
            //ewh.WaitOne();
            //Console.WriteLine("Atfer finishing RunMethod() !");
            //Boolean isContinue = true;
            
            ////쓰레드 종료 기다리기3​
            //void RunMethod3(object obj)
            //{
            //    int value1 = (int)obj;
            //    //for(int i=0 ; i<value1 ; i++)
            //    int i = 0;
            //    while (isContinue)
            //    {
            //        i++;
            //        Console.WriteLine(i + " / " + value1);
            //        Thread.Sleep(1000);
            //    }
            //    Console.WriteLine("RunMethod finished !");}
            //isContinue = true;
            //Thread thread11 = new Thread(RunMethod3);
            //thread3.Start(15);
            //isContinue = false;

            //Console.WriteLine("Atfer finishing RunMethod() !");
        }
       
        // 실행문장
        static void Run()
        {
            for(int i =0; i<100; i++)
            {
                Console.WriteLine("In Run, i= " + i);
            }
        }

    }
    //쓰레드 실행 함수내용 실행
    class AnyJob
    {
        public void ThreadJob()
        {
            Console.WriteLine("AnyJob.ThreadJob()");
        }
        public void RunMethod(object obj)
        {
            int value1 = (int)obj;
            Console.WriteLine(" value1 : " + value1);
        }

    }
    class Param
    {
        public int value1;
        public float value2;
        public Param(int value1, float value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }
        static public void RunMethod(object obj)

        {
            Param param = (Param)obj;
            Console.WriteLine(" value1 : " + param.value1 + ", value2 : " + param.value2);
        }
    }
}
