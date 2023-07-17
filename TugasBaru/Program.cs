using System;
using System.Collections.Generic;

namespace TaskFoobar
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<int, string> rules = new Dictionary<int, string>();
			rules.Add(3, "foo");
			rules.Add(5, "bar");
			

			Console.Write("Input number: ");
			int n = Convert.ToInt32(Console.ReadLine());

			FoobarPrinter printer = new FoobarPrinter();
			printer.PrintNumbers(n, rules);
		}
	}

}
