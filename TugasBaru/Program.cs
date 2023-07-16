// See https://aka.ms/new-console-template for more information

namespace TaskFoobar
{
	class program
	{
		static void Main(string[] args)
		{
			Dictionary<int, string> rules = new Dictionary<int, string>();
			rules.Add(3, "foo");
			rules.Add(5, "bar");
			
			Console.Write("Input number: ");
			int n = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("n = " + n);
			Console.Write("Result: ");
			
			FoobarPrinter printer = new FoobarPrinter();
			printer.PrintNumbers(n, rules);
			
			Console.WriteLine();
		}
	}
}
