using System;

namespace Mid
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string s = Console.ReadLine();
			int sum = 0;
			int q = int.Parse(s);
			while (q > 0)
			{
				sum += q % 10;
				q /= 10;
			}
			Console.WriteLine(sum);
		}
	}
}
