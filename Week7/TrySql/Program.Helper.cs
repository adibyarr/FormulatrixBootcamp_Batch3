using EFCore;

namespace ProgramEFCore;
partial class Program
{
	static void SectionTitle(string title)
	{
		ConsoleColor previousColor = Console.ForegroundColor;
		Console.ForegroundColor = ConsoleColor.DarkCyan;
		Console.WriteLine("");
		Console.WriteLine($" * {title}");
		Console.WriteLine("*");
		Console.ForegroundColor = previousColor;
		
	}
	static void Fail(string message)
	{
		ConsoleColor previousColor = Console.ForegroundColor;
		Console.ForegroundColor = ConsoleColor.DarkYellow;
		Console.WriteLine($"Fail > {message}");
		Console.ForegroundColor = previousColor;
	}
	static void Info(string message)
	{
		ConsoleColor previousColor = Console.ForegroundColor;
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine($"Info = {message}");
		Console.ForegroundColor = previousColor;
	}
	static void Printer(string message)
	{
		ConsoleColor previousColor = Console.ForegroundColor;
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine($"{message}");
		Console.ForegroundColor = previousColor;
	}
	static string GetInput()
	{
		string input;
		do
		{
			input = Console.ReadLine();
		} while (input == null);
		return input;
	}
}