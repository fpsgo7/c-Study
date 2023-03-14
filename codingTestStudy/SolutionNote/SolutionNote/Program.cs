using System;

namespace SolutionNote
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] choose = Console.ReadLine().Split();
			int basketCount = int.Parse(choose[0])+1;
			int count = int.Parse(choose[1]);
			int[] basket = new int[basketCount];
			int[] newBasket = new int[basketCount];

			for(int i = 1; i<basket.Length; i++)
            {
				basket[i] = i;
            }
			while(count-- > 0)
            {
				string[] choose2 = Console.ReadLine().Split();
				int startN = int.Parse(choose2[0]);
				int endN = int.Parse(choose2[1]);
				int middleN = int.Parse(choose2[2]);
				for(int i = startN; i <= endN; i++)
                {
					newBasket[i] = basket[(i + middleN - 2 * startN)
						% (endN - startN+1) + startN];

                }
				for(int i = startN; i<= endN; i++)
                {
					basket[i] = newBasket[i];
                }

			}
			for (int i = 1; i < basket.Length; i++)
			{
				Console.Write(basket[i]+" ");
			}
		}
	}
}

