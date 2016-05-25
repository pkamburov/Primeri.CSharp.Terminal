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

			//Примери

			a = 5; 
			b = 10;
			sum = a + b;

			// Писане в конзола
			Console.Write ( a );
			Console.Write (" + ");
			Console.Write ( b );
			Console.Write (" = ");
			Console.WriteLine ( sum );

			//Допълнителни оператори
			Console.WriteLine ("\nHow to use +=");
			a += b; //a = 10 + 5, a = a + b;
			Console.WriteLine ( a );

			Console.WriteLine ("\nHow to use -=");
			a -= b;
			Console.WriteLine (a);

			Console.WriteLine ("\nHow to use *=");
			a *= b;
			Console.WriteLine (a);

			Console.WriteLine ("\nHow to use ++");
			a++;
			Console.WriteLine (a);
			Console.ReadLine ();




		}
	}
}
