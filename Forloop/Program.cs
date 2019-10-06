using System;

namespace Forloop
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = 0;

			//int i = = - start of the loop, i < 10 - stop;
			for (int i = 1; i < 11; i++)
			{
				Console.WriteLine($"i equals {i}");
			}

			Console.WriteLine("\n");

			for (int j = 10; j > -1; j--)
			{
				Console.WriteLine($"j equals {j}");

			}

			Console.ReadLine();
		}
	}
}
