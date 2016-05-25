using System;

namespace TableProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на таблица
			string[,] table = new string[2, 3];

			//Въвеждане на първи ред
			table[0, 0] = "John"; table[0, 1] = "Doe"; table[0, 2] = "29";

			//Въвеждане на втори ред
			table[1, 0] = "Dohn"; table[1, 1] = "Joe"; table[1, 2] = "41";

			//Печат
			Console.Write ("Wich row you want to see: ");
			int _index = Convert.ToInt32 (Console.ReadLine ()) - 1;

			Console.WriteLine ((table[_index, 0])[0] + ". " + table[_index, 1] + ", " + table[_index, 2] + " " +
				"r.");
		}
	}
}
