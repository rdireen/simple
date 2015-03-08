using System;

namespace Calculator
{
	public class Calculate
	{
		public int x;
		public int y;

		public Calculate (int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		public int add()
		{
			return x + y;
		}

		public int sub()
		{
			return x - y;
		}

		public int mult()
		{
			return x * y;
		}

		public int div()
		{
			return x / y;
		}

	}
}

