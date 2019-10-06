using System;

namespace erinevadylesanded
{
	class Program
	{
		static void Main(string[] args)
		{
			/*Start:
			int userNumber;
			Console.WriteLine("Enter a number: ");
			userNumber = Int32.Parse(Console.ReadLine());

			if (userNumber >= 1)
			{
				Console.WriteLine("User number is positive");
			}
			else if (userNumber ==0)
			{
				Console.WriteLine("User number is zero");
			}
			else if (userNumber < -1)
			{
				Console.WriteLine("User number is negative");
			}
			goto Start;

			Console.ReadLine();*/

			/*Start:
			Console.WriteLine("Enter a number: ");
			int userNumber;
			userNumber = Int32.Parse(Console.ReadLine());

			if (userNumber % 5  == 0)
			{
				Console.WriteLine("Number jagub 5-ga");
			}
			else if (userNumber % 11 ==0)
			{
				Console.WriteLine("Number jagub 11-ga");
			}
			else
			{
				Console.WriteLine("Ei jagu!");
			}

			goto Start;
			Console.ReadLine();*/

			Start:

			Console.WriteLine("Enter a number: ");
			int userNumber;
			userNumber = Int32.Parse(Console.ReadLine());

			if (userNumber % 2 ==0)
			{
				Console.WriteLine("Number jagub 2-ga- paarisarv");
			}
			
			else
			{
				Console.WriteLine("Ei jagu- paaritu arv!");
			}

			goto Start;
			Console.ReadLine(); 
		}
	}
}
