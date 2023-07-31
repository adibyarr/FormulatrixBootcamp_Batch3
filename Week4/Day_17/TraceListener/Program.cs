using System.Diagnostics;
namespace MyProgram
{
	class Program 
	{
		static void Main()
		{
			ConsoleTraceListener consoleTraceListener = new ConsoleTraceListener();
			Trace.Listeners.Add(consoleTraceListener);
			
			Trace.WriteLine("starting program.");
			
			int x = 5;
			int y = 8;
			
			Trace.WriteLine($"x = {x}, y ={y}");
			
			int sum = x + y;
			Trace.WriteLine($"The sum of {x} and {y} is {sum}");
			
			Trace.WriteLine("Program Complete");
		}
	}
}
