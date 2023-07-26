using System;

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


			printer.AddRule(2, "fizz");
			printer.AddRule(4, "buzz");

			// Print numbers dengan rules sekarang
			Console.WriteLine("Numbers with current rules:");
			printer.PrintNumbers(n);
			Console.WriteLine();

			// Print Numbers dengan rules tambahan
			Console.WriteLine("Numbers with additional rules:");
			printer.PrintNumbers(n);
			Console.WriteLine();

			// Remove dengan rules yang spesifik
			printer.RemoveRule(5);
			Console.WriteLine("Numbers after remove 'bar' rule:");
			printer.PrintNumbers(n);
			Console.WriteLine();

			//Remove semua rules
			printer.RemoveAllRules();
			Console.WriteLine("Numbers after removing all rules:");

			printer.PrintNumbers(n);
		}
	}
}
