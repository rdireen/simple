using System;
using Calculator;

namespace simple
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int x = 0;
			int y = 0;
			int r = 0;

			Console.WriteLine ("Here is a calculator");

			Console.WriteLine ("Enter x: ");
			var line_x = Console.ReadLine ();
			Console.WriteLine ("Enter x: ");
			var line_y = Console.ReadLine ();

			if (int.TryParse (line_x, out x) && int.TryParse (line_y, out y)) {

				var calc = new Calculate (x, y);

				Console.WriteLine ("");
				Console.WriteLine ("Enter 1) add; 2) sub; 3) mult; 4) div: ");
				var calc_type = Console.ReadLine ();

				switch (calc_type) {

				case "1":
					r = calc.add ();
					break;
				case "2":
					r = calc.sub ();
					break;
				case "3":
					r = calc.mult ();
					break;
				case "4":
					r = calc.div ();
					break;
				}

				Console.WriteLine (String.Format("Your result is {0}", r)); 



			} else {
				Console.WriteLine ("Enter integers only.");
			}

			Console.WriteLine ("*** THE END ***");

		}
	}
}
