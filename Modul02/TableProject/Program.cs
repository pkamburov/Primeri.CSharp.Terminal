using System;

namespace TableProject
{
	class MainClass
	{
		enum ti {Name=0, Surname, Years};

		public static void Main (string[] args)
		{
			//Дефиниране на таблица
			string[,] table = new string[2, 3];

			//Въвеждане на първи ред
			table[0, (int)ti.Name] = "John"; table[0, (int)ti.Surname] = "Doe"; table[0, (int)ti.Years] = "29";

			//Въвеждане на втори ред
			table[1, (int)ti.Name] = "Dohn"; table[1, (int)ti.Surname] = "Joe"; table[1, (int)ti.Years] = "41";

			//Печат
			Console.Write ("Wich row you want to see: ");
			int _index = Convert.ToInt32 (Console.ReadLine ()) - 1;

			Console.WriteLine (
				(table[_index, (int)ti.Name])[0] + ". " + 
				table[_index, (int)ti.Surname] + ", " + 
				table[_index, (int)ti.Years] + " " + "r.");
		}
	}
}
