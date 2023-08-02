using System;
using System.Threading.Tasks;

class Program
{
	private static object myLock = new object();
	private static int counter = 0;
	private static CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

	static async Task IncrementCounterAsync(CancellationToken cancellationToken)
	{
		while (!cancellationToken.IsCancellationRequested)
		{
			await Task.Delay(1000); // Asynchronous delay
			lock (myLock)
			{
				Console.WriteLine($"Task {Task.CurrentId} ngelock.");
				counter++;
				Console.WriteLine($"Task {Task.CurrentId} ngelepass. Counter: {counter}");
			}
		}
	}

	static async Task Main()
	{
		Task[] tasks = new Task[5];
		for (int i = 0; i < tasks.Length; i++)
		{
			tasks[i] = IncrementCounterAsync(cancellationTokenSource.Token);
		}
		
		Console.ReadLine();
		cancellationTokenSource.Cancel();

		await Task.WhenAll(tasks);

		Console.WriteLine("Program selesai.");
	}
}
