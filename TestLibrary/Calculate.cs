using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Calculator
{
    /// <summary>
    /// A little calculator to process <c>int</c> values.
    /// </summary>
    /// <exception cref="DivideByZeroException"> Only with div()</exception>
	public class Calculate
	{
		public int x;
		public int y;
        Dictionary<string, string> values;

        /// <summary>
        /// Initializes a new instance of the <see cref="Calculator.Calculate"/> class.
        /// </summary>
        /// <remarks>
        /// This is a <c>DocumentationSample</c>:
        ///     <example> You make one of these like this: 
        ///         <code>
        ///         var calc = new Calculate(3,2);
        ///         </code>
        ///     </example>
        /// </remarks>
        /// <param name="x">The x value used in the calculation.</param>
        /// <param name="y">The y value used in the calculation.</param>
        /// <returns>Nothing</returns>

		public Calculate (int x, int y)
		{
			this.x = x;
			this.y = y;

            string json = @"{""x"":""value1"",""y"":""value2""}";

            this.values = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
		}

        /// <summary>
        /// Adds the two variables.
        /// </summary>
        /// <seealso cref="sub()">
        /// <seealso cref="mult()">
        /// <seealso cref="div()">
        /// <returns>The sum of the two variables</returns>
		public int add()
		{
			return x + y;
		}

        /// <summary>
        /// Subtract the two variables.
        /// </summary>
        /// <seealso cref="add()">
        /// <seealso cref="mult()">
        /// <seealso cref="div()">
        /// <returns>The difference of the two variables</returns>
		public int sub()
		{
			return x - y;
		}

        /// <summary>
        /// Multiply the two variables.
        /// </summary>
        /// <remarks>
        ///     <example>
        ///     Code sections must be placed within `remarks` tags to be 
        ///     rendered by doxygen properly.
        ///         <code>
        ///         //Here is an example of how to multiply two integers.
        /// 
        ///         var calc = new Calculate(4,2);
        ///         var r = calc.mult();
        ///     </code>
        ///     </example>
        /// </remarks>
        /// 
        /// <seealso cref="sub()">
        /// <seealso cref="mult()">
        /// <seealso cref="div()">
        /// <returns>The product of the two variables</returns>
		public int mult()
		{
			return x * y;
		}

        /// <summary>
        /// Divide the two variables.
        /// </summary>
        /// 
        /// <returns>The quotient of the two variables</returns>
        /// 
        /// <remarks>
        /// If you are going to add examples of code, make sure you put them
        /// within these `remarks` tags.
        ///     <example>
        ///     The following example uses 
        ///     the code to divide two numbers:
        ///         <code>
        ///                 var calc = new Calculate(4,2);
        ///         var r = calc.div();
        ///         </code>
        ///     </example>
        /// </remarks>
        /// 
        /// 
        /// <seealso cref="sub()">
        /// <seealso cref="mult()">
        /// <seealso cref="add()">
        /// <exception cref="DivideByZeroException"></exception>
		public int div()
		{
            Console.WriteLine (this.values ["x"]);
			return x / y;

		}

	}
}

