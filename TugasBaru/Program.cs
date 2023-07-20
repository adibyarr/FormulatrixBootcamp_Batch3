using System;
using System.Collections.Generic;

namespace TaskFoobar
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Input number: ");
			int n = Convert.ToInt32(Console.ReadLine());

			FoobarPrinter printer = new FoobarPrinter();
			printer.AddRule(3, "foo");
			printer.AddRule(5, "bar");
			printer.PrintNumbers(n);
		}
	}

}
