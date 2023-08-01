using System;
using System.Threading.Tasks;

public class Program
{
	public async static Task Main()
	{
		Console.WriteLine("Main started: ");
		Task task1 = Task1Async();
		Task task2 = Task2Async();
		
		await Task.WhenAll(task1, task2);
		Console.WriteLine("Main ended..");
		
	} 
	public async static Task Task1Async()
	{
		for (int i = 0; i <= 5; i++)
		{
			await Task.Delay(2000);
			Console.WriteLine($"Task 1 - pembagian {i}");
		}
	}
	public async static Task Task2Async()
	{
		for (int i = 0; i <= 5; i++)
		
		{
			await Task.Delay(2000);
			Console.WriteLine($"Task 2 - Pembagian {i}");
		}
	}
}