using System;
using System.Threading;
using System.Threading.Tasks;


public class Program
{
	// Maksimum jumlah izin yang dapat diberikan oleh SemaphoreSlim
	const int MaxConcurrentThreads = 5;

	// SemaphoreSlim instance
	static SemaphoreSlim semaphore = new SemaphoreSlim(5, 5);

	static void Main(string[] args)
	{
		// Membuat beberapa task yang menggunakan izin dari SemaphoreSlim
		Task[] tasks = new Task[5];
		for (int i = 1; i <= 5; i++)
		{
			int threadNumber = i;
			tasks[i - 1] = Task.Run(() => AccessResource(threadNumber));
		}

		// Menunggu semua task selesai
		Task.WaitAll(tasks);

		Console.ReadLine();
	}

	static async void AccessResource(int threadNumber)
	{
		Console.WriteLine($"Thread {threadNumber} is waiting for access.");

		// Menunggu izin dari SemaphoreSlim untuk mengakses sumber daya
		await semaphore.WaitAsync();

		Console.WriteLine($"Thread {threadNumber} is accessing the resource.");

		// Simulasi akses sumber daya
		await Task.Delay(2000);

		Console.WriteLine($"Thread {threadNumber} has released the resource.");

		semaphore.Release();
	}
}
