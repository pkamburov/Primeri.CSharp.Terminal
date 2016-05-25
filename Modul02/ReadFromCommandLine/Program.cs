using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a = 5, b = 0;

			//Въвеждане на входни параметри
			Console.Write ( "Please enter a: " );
			b = Convert.ToInt32 (Console.ReadLine ());

			//Печат на резултат
			Console.WriteLine ( "Result is " + (a + b).ToString() + "\n\n\n");

			string test = "1";
			test += ", 2";
			test += ", 100";
			test += ", 4";
			test += ", 5";

			Console.WriteLine (" += : " + test + "\n\n");

			test = test.Replace (", ", ";");
			Console.WriteLine ("Replace : " + test + "\n");

			Console.WriteLine ("3rd sign: " + test.Split (';') [2]);
		}
	}
}
