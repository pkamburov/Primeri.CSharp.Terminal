using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			//Дефиниране на променливи

			int a = 0, b = 0;
			int sum = 0;
			string program_name = "Modul02 - Examples";
			string program_version = "1.0";
			//Примери

			a = 5; 
			b = 10;
			sum = a + b;
			// За програмата
			Console.WriteLine (program_name);
			Console.WriteLine ("Version: " + program_version + "\n\n" );
			// Писане в конзола
			Console.Write (a);
			Console.Write (" + ");
			Console.Write (b);
			Console.Write (" = ");
			Console.WriteLine (sum);

			//Допълнителни оператори
			Console.WriteLine ("\nHow to use +=");
			a += b; //a = 10 + 5, a = a + b;
			Console.WriteLine (a);

			Console.WriteLine ("\nHow to use -=");
			a -= b;
			Console.WriteLine (a);

			Console.WriteLine ("\nHow to use *=");
			a *= b;
			Console.WriteLine (a);

			Console.WriteLine ("\nHow to use ++");
			a++;
			Console.WriteLine (a);

			Console.WriteLine ("Division: " + (7 / 3).ToString ()); // -> 2 (7 / 3 = 2,3333)
			Console.WriteLine ("Division: " + (7 % 3).ToString ()); // -> 1 (1 / 3 = 0,3333) 

		}
	}
}
