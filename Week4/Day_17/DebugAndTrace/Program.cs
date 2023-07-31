using System;
using System.Diagnostics;

class Program 
{
	static void Main()
	{
		int x = 6, y = 9;
		
		
		Debug.WriteLine("Starting Program");
		Debug.WriteLine("x = " + x);
		Debug.WriteLine("y = "+ y);
		Debug.WriteLine("");
		
		Trace.WriteLine("Calculate x + y.. ");
		int sum = x + y;
		Trace.WriteLine("x + y = "+ sum);
		Trace.WriteLine("");
		
		Debug.Assert(sum == 11, "The sum of x and y should be 11");
		
		Debug.WriteLine("Press any key to exit");
	}
}