using System;
using System.IO;
namespace ppppp
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string s = @"C:\Users\Данара\Documents\test";
			DirectoryInfo dir = new DirectoryInfo(s);
			string ss = String.Empty;
			StreamWriter sw = new StreamWriter("result.txt");
			FileInfo[] f = dir.GetFiles();
			foreach (FileInfo fs in f)
			{
				StreamReader sr = new StreamReader(fs.FullName);
				if (sr.ReadLine() == "yes")
				{
					ss = ss + fs.Name;
					ss = ss + "\n";
				}
				sw.WriteLine(ss);
				sw.Close();
				sr.Close();
			}
		}
	}
}
