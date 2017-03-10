using System;
using System.Threading;

namespace Svetofor
{
	class MainClass
	{
		public static int P = 0, Q = 0;

		public static void Mig()
		{
			string a = "****\n****\n****";
			ConsoleColor colora = ConsoleColor.Red;
			ConsoleColor colorb = ConsoleColor.Yellow;
			ConsoleColor colorc = ConsoleColor.Green;
			ConsoleColor color = ConsoleColor.White;
			while (true)
			{
				P++;
				P %= 3;
				++Q;
				Console.Clear();
				Console.ForegroundColor = color;
				if (P == 0)
				{
					Console.ForegroundColor = colora;
					Console.WriteLine(a);
					Console.ForegroundColor = color;
					Console.WriteLine(a);
					Console.WriteLine(a);
				}
				if (P == 1)
				{
					Console.WriteLine(a);
					Console.ForegroundColor = colorb;
					Console.WriteLine(a);
					Console.ForegroundColor = color;
					Console.WriteLine(a);
				}
				if (P == 2)
				{
					Console.WriteLine(a);
					Console.WriteLine(a);
					Console.ForegroundColor = colorc;
					Console.WriteLine(a);
					Console.ForegroundColor = color;
				}
				Thread.Sleep(1000);
			}
		}
		public static void Main(string[] args)
		{
			Thread thread = new Thread(Mig);
			thread.Start();
			while (true)
			{
				if (Q > 100)
					break;
			}
		}
	}
}
