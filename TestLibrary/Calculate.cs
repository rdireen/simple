using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Calculator
{
	public class Calculate
	{
		public int x;
		public int y;
        Dictionary<string, string> values;

		public Calculate (int x, int y)
		{
			this.x = x;
			this.y = y;

            string json = @"{""x"":""value1"",""y"":""value2""}";

            this.values = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
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
            Console.WriteLine (this.values ["x"]);
			return x / y;

		}

	}
}

