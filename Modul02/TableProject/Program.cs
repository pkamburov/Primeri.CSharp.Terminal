using System;

namespace TableProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] row = new string[3];

			row [0] = "Row 1";
			row [1] = "Row 2";
			row [2] = "Row 3";

			Console.WriteLine ("Array row: " + row[0] + ", " + row[1] + ", " + row[2] + "\n");

			string[] parse = "1,2,3,4,5,6,7,8,9".Split (',');
			Console.WriteLine ("Array length:\n" + "1,2,3,4,5,6,7,8,9\n\nis:" + parse.Length);

			string list1 = string.Join (";", parse);
			Console.WriteLine ("New String is:\n" + list1 + "\n\n");
		}
	}
}
