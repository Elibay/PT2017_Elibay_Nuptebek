using System;
using System.Collections.Generic;
using System.IO;

namespace Mid
{
	class MainClass
	{
		class Polygon
		{
			public List<Point> points;
			public Polygon()
			{
				points = new List<Point>();
			}
			override public string ToString()
			{
				string a = string.Empty;
				for (int i = 0; i < points.Count; ++ i)
				{
					a += points[i].x;
					a += " ";
					a += points[i].y;
					a += "\n";
				}
				return a;
			}
			double GetLenth(Point a, Point b)
			{
				return Math.Sqrt((a.x - b.x) * (a.x - b.x) + (a.y - b.y) * (a.y - b.y));
			}
			public double getPerimeter()
			{
				double sum = 0;
				int n = points.Count;
				for (int i = 1; i < n; ++i)
				{
					sum += GetLenth(points[i], points[i - 1]);
				}
				sum += GetLenth(points[0], points[n - 1]);
				return sum;
			}
			public void Show()
			{
				DirectoryInfo dir = new DirectoryInfo(@"/Users/elibay/Projects/Polygon");
				FileInfo[] files = dir.GetFiles();
				foreach (var file in files)
				{
					Console.WriteLine(file.Name);
				}
			}
			public void Get(string ss)
			{
				StreamReader sr = new StreamReader(ss);
				string[] s = sr.ReadLine().Split();
				for (int i = 0; i < s.Length; i += 2)
				{
					if (i + 1 >= s.Length)
						continue;
					int x = int.Parse(s[i]);
					int y = int.Parse(s[i + 1]);
					points.Add(new Point(x, y));
				}
			}
		}
		public static void Main(string[] args)
		{
			Polygon a = new Polygon();
			string b = @"/Users/elibay/Projects/Polygon/" + Console.ReadLine();
			a.Get(b);
			Console.WriteLine(a);
		}
	}
}
