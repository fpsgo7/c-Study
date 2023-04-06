using System;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Matter3_24
{
	[MemoryDiagnoser]
	public class Search
	{
		int[] nums = new int[50001];

		public Search()
		{
			//반복문에서 .Length()를 실행하면
			// 바복될 때마다 해당 조건 식을 실행하여
			// 길이를 쓸떈 따로 캐싱한다.
			int length = nums.Length;
			for (int i = 0; i < length; i++)
            {
				nums[i] = i;
            }
		}
		// 문장이 맞는지 확인용
		public void SequentialSearch()
		{
			int length = nums.Length;
			int searchNum = 15000;
            for (int i = 0; i < length; i++)
            {
                if (nums[i] == searchNum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("값이 없읍니다.");
		}
		public void BinarySearch()
        {
			int searchNum = 15000;
            int max = nums.Length - 1;
            int min = 0;
            // 간단 한 조건문일 경우 while 안에 넣어 가독성을 높인다.
            while (min >= max)
            {
                int middle = nums[(max+min)/2];// 컴파일러에서 최적화를 해줘 여기서 반복 선언해도 문제없다.
                middle = (max + min) / 2;
                // else if를 활용하여 조건 확인 횟수를 줄인다.
                if (searchNum > middle)
                {
                    Console.WriteLine($"최소 {min} 최대 {max} 중간{middle}");
                    min = middle + 1;
                }
                else if (searchNum < middle)
                {
                    Console.WriteLine($"최소 {min} 최대 {max} 중간{middle}");
                    max = middle - 1;
                }
                else if (searchNum == middle)
                {
                    Console.WriteLine("찾았습니다." + middle);
                    return;
                }

            }
            Console.WriteLine("값이 없습니다.");

        }
        // 함수를 따로 꺼내둔다.
        public void SequentialSearch(int searchNum)
        {
            int length = nums.Length;
            for (int i = 0; i < length; i++)
            {
                if (nums[i] == searchNum)
                {
                    return;
                }
            } 
        }
        public void BinarySearch(int searchNum)
        {
            int max = nums.Length - 1;
            int min = 0;
            while (min >= max)
            {
                int middle = nums[(max + min) / 2];
                middle = (max + min) / 2;
                if (searchNum > middle)
                    min = middle + 1;
                else if (searchNum < middle)
                    max = middle - 1;
                else if (searchNum == middle)
                    return;
            }
        }
        //|               Method |        Mean |     Error |    StdDev | Allocated |
        //|--------------------- |------------:|----------:|----------:|----------:|
        //|   SequentialSearch10 |   5.9077 ns | 0.0459 ns | 0.0430 ns |         - |
        //| SequentialSearch1000 | 541.6304 ns | 4.0965 ns | 3.6314 ns |         - |
        //|       BinarySearch10 |   0.7746 ns | 0.0299 ns | 0.0279 ns |         - |
        //|    BinarySearch10000 |   0.7725 ns | 0.0064 ns | 0.0060 ns |         - |
        [Benchmark]
        public void SequentialSearch10()
        {
            SequentialSearch(10);
        }
        [Benchmark]
        public void SequentialSearch1000()
        {
            SequentialSearch(1000);
        }
        [Benchmark]
        public void BinarySearch10()
        {
            BinarySearch(10);
        }
        [Benchmark]
        public void BinarySearch10000()
        {
            BinarySearch(10000);
        }
    }

}
