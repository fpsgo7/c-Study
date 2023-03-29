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
			int searchNum = 10000;
            if (searchNum >= 0 && searchNum <= 50000)
            {
                for (int i = 0; i < length; i++)
                {
                    if (nums[i] == searchNum)
                    {
                        Console.WriteLine(i);
                        return;
                    }
                }
            }   
		}
		public void BinarySearch()
        {
			int searchNum = 60000;
          

            int max = nums[nums.Length-1];
			int min = nums[0];
			int middle;
            if (searchNum >= 0 && searchNum <= 50000)
            {
                while (true)
                {
                    middle = (max + min) / 2;
                    if (searchNum == middle)
                    {
                        Console.WriteLine("찾았습니다." + middle);
                        return;
                    }

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

                }
            }
                
        }

        //순차 탐색 0,1000,5000,10000,20000,30000,40000,50000

        [Benchmark]
        public void SequentialSearch0()
        {
            int length = nums.Length;
            int searchNum = 0;
            if (searchNum >= 0 && searchNum <= 50000)
            {
                for (int i = 0; i < length; i++)
                {
                    if (nums[i] == searchNum)
                    {
                        return;
                    }
                }
            }
        }
        [Benchmark]
        public void SequentialSearch1000()
        {
            int length = nums.Length;
            int searchNum = 1000;
            if (searchNum >= 0 && searchNum <= 50000)
            {
                for (int i = 0; i < length; i++)
                {
                    if (nums[i] == searchNum)
                    {
                        return;
                    }
                }
            }
        }
        [Benchmark]
        public void SequentialSearch5000()
        {
            int length = nums.Length;
            int searchNum = 5000;
            if (searchNum >= 0 && searchNum <= 50000)
            {
                for (int i = 0; i < length; i++)
                {
                    if (nums[i] == searchNum)
                    {
                        return;
                    }
                }
            }
        }
        [Benchmark]
        public void SequentialSearch10000()
        {
            int length = nums.Length;
            int searchNum = 10000;
            if (searchNum >= 0 && searchNum <= 50000)
            {
                for (int i = 0; i < length; i++)
                {
                    if (nums[i] == searchNum)
                    {
                        return;
                    }
                }
            }
        }
        [Benchmark]
        public void SequentialSearch20000()
        {
            int length = nums.Length;
            int searchNum = 20000;
            if (searchNum >= 0 && searchNum <= 50000)
            {
                for (int i = 0; i < length; i++)
                {
                    if (nums[i] == searchNum)
                    {
                        return;
                    }
                }
            }
        }
        [Benchmark]
        public void SequentialSearch30000()
        {
            int length = nums.Length;
            int searchNum = 30000;
            if (searchNum >= 0 && searchNum <= 50000)
            {
                for (int i = 0; i < length; i++)
                {
                    if (nums[i] == searchNum)
                    {
                        return;
                    }
                }
            }
        }

        [Benchmark]
        public void SequentialSearch40000()
        {
            int length = nums.Length;
            int searchNum = 40000;
            if (searchNum >= 0 && searchNum <= 50000)
            {
                for (int i = 0; i < length; i++)
                {
                    if (nums[i] == searchNum)
                    {
                        return;
                    }
                }
            }
        }
        [Benchmark]
        public void SequentialSearch50000()
        {
            int length = nums.Length;
            int searchNum = 50000;
            if (searchNum >= 0 && searchNum <= 50000)
            {
                for (int i = 0; i < length; i++)
                {
                    if (nums[i] == searchNum)
                    {
                        return;
                    }
                }
            }

        }
        [Benchmark]
        public void SequentialSearch60000()
        {
            int length = nums.Length;
            int searchNum = 60000;
            if (searchNum >= 0 && searchNum <= 50000)
            {
                for (int i = 0; i < length; i++)
                {
                    if (nums[i] == searchNum)
                    {
                        return;
                    }
                }
            }
                
        }

        //이진 탐색 테스트 0,1000,5000,10000,20000,30000,40000,50000
        [Benchmark]
        public void BinarySearch0()
        {
            int searchNum = 0;
            int max = nums[nums.Length - 1];
            int min = nums[0];
            int middle;
            if (searchNum >= 0 && searchNum <= 50000)
            {
                while (true)
                {
                    middle = (max + min) / 2;
                    if (searchNum == middle)
                    {
                        return;
                    }
                    if (searchNum > middle)
                    {
                        min = middle + 1;
                    }
                    else if (searchNum < middle)
                    {
                        max = middle - 1;
                    }
                }
            }
        }
        [Benchmark]
        public void BinarySearch1000()
        {
            int searchNum = 1000;
            int max = nums[nums.Length - 1];
            int min = nums[0];
            int middle;
            if (searchNum >= 0 && searchNum <= 50000)
            {
                while (true)
                {
                    middle = (max + min) / 2;
                    if (searchNum == middle)
                    {
                        return;
                    }
                    if (searchNum > middle)
                    {
                        min = middle + 1;
                    }
                    else if (searchNum < middle)
                    {
                        max = middle - 1;
                    }
                }
            }
        }
        [Benchmark]
        public void BinarySearch5000()
        {
            int searchNum = 5000;
            int max = nums[nums.Length - 1];
            int min = nums[0];
            int middle;
            if (searchNum >= 0 && searchNum <= 50000)
            {
                while (true)
                {
                    middle = (max + min) / 2;
                    if (searchNum == middle)
                    {
                        return;
                    }
                    if (searchNum > middle)
                    {
                        min = middle + 1;
                    }
                    else if (searchNum < middle)
                    {
                        max = middle - 1;
                    }
                }
            }
        }
        [Benchmark]
        public void BinarySearch10000()
        {
            int searchNum = 10000;
            int max = nums[nums.Length - 1];
            int min = nums[0];
            int middle;
            if (searchNum >= 0 && searchNum <= 50000)
            {
                while (true)
                {
                    middle = (max + min) / 2;
                    if (searchNum == middle)
                    {
                        return;
                    }
                    if (searchNum > middle)
                    {
                        min = middle + 1;
                    }
                    else if (searchNum < middle)
                    {
                        max = middle - 1;
                    }
                }
            }
        }
        [Benchmark]
        public void BinarySearch20000()
        {
            int searchNum = 20000;
            int max = nums[nums.Length - 1];
            int min = nums[0];
            int middle;
            if (searchNum >= 0 && searchNum <= 50000)
            {
                while (true)
                {
                    middle = (max + min) / 2;
                    if (searchNum == middle)
                    {
                        return;
                    }
                    if (searchNum > middle)
                    {
                        min = middle + 1;
                    }
                    else if (searchNum < middle)
                    {
                        max = middle - 1;
                    }
                }
            }
        }
        [Benchmark]
        public void BinarySearch30000()
        {
            int searchNum = 30000;
            int max = nums[nums.Length - 1];
            int min = nums[0];
            int middle;
            if (searchNum >= 0 && searchNum <= 50000)
            {
                while (true)
                {
                    middle = (max + min) / 2;
                    if (searchNum == middle)
                    {
                        return;
                    }
                    if (searchNum > middle)
                    {
                        min = middle + 1;
                    }
                    else if (searchNum < middle)
                    {
                        max = middle - 1;
                    }
                }
            }
        }
        [Benchmark]
        public void BinarySearch40000()
        {
            int searchNum = 40000;
            int max = nums[nums.Length - 1];
            int min = nums[0];
            int middle;
            if (searchNum >= 0 && searchNum <= 50000)
            {
                while (true)
                {
                    middle = (max + min) / 2;
                    if (searchNum == middle)
                    {
                        return;
                    }
                    if (searchNum > middle)
                    {
                        min = middle + 1;
                    }
                    else if (searchNum < middle)
                    {
                        max = middle - 1;
                    }
                }
            }
        }
        [Benchmark]
        public void BinarySearch50000()
        {
            int searchNum = 50000;

            int max = nums[nums.Length - 1];
            int min = nums[0];
            int middle;
            if (searchNum >= 0 && searchNum <= 50000)
            {
                while (true)
                {
                    middle = (max + min) / 2;
                    if (searchNum == middle)
                    {
                        return;
                    }
                    if (searchNum > middle)
                    {
                        min = middle + 1;
                    }
                    else if (searchNum < middle)
                    {
                        max = middle - 1;
                    }
                }
            }
        }
        [Benchmark]
        public void BinarySearch60000()
        {
            int searchNum = 60000;
           
            int max = nums[nums.Length - 1];
            int min = nums[0];
            int middle;
            if (searchNum >= 0 && searchNum <= 50000)
            {
                while (true)
                {
                    middle = (max + min) / 2;
                    if (searchNum == middle)
                    {
                        return;
                    }
                    if (searchNum > middle)
                    {
                        min = middle + 1;
                    }
                    else if (searchNum < middle)
                    {
                        max = middle - 1;
                    }
                }
            }
        }
    }

}
