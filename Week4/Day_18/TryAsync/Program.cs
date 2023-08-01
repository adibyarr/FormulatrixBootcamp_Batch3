using System;
using System.Threading.Tasks;

class TryAsyncProgram
{
	public async static Task Main()
	{
		Console.WriteLine("Started program.");
		
		int result = await TryAsyncProgram2();
		
		Console.WriteLine("Async task complete. Result: " + result);
	}
	public async static Task<int> TryAsyncProgram2()
	{
		await Task.Delay(5000);
		return 42;
	}
}