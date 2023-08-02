using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
	private static AutoResetEvent dataAvailableEvent = new AutoResetEvent(false);
	private static int data;
	private static CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

	static async Task ProducerTask(CancellationToken cancellationToken)
	{
		Random random = new Random();
		while (!cancellationToken.IsCancellationRequested)
		{
			// Produksi data
			data = random.Next(1, 100);
			Console.WriteLine($"Producer: Producing data: {data}");

			// Memberi sinyal kepada ConsumerTask bahwa data tersedia
			dataAvailableEvent.Set();

			// Menunggu sejenak sebelum menghasilkan data berikutnya
			await Task.Delay(random.Next(500, 2000));
		}
	}

	static async Task ConsumerTask(CancellationToken cancellationToken) 
	{
		while (!cancellationToken.IsCancellationRequested)
		{
			// Menunggu hingga data tersedia
			dataAvailableEvent.WaitOne();

			// Konsumsi data
			Console.WriteLine($"Consumer: Consuming data: {data}");

			// Menunggu sejenak sebelum mencoba mengkonsumsi data berikutnya
			await Task.Delay(1000);
		}
	}

	static async Task Main()
	{
		// Jalankan kedua task secara asynchronous
		Task producerTask = ProducerTask(cancellationTokenSource.Token);
		Task consumerTask = ConsumerTask(cancellationTokenSource.Token);
		Console.WriteLine("Enter untuk menghentikan perulangan");
		Console.ReadLine();
		
		cancellationTokenSource.Cancel();

		// Tunggu kedua task selesai (tidak akan terjadi karena task ini berjalan secara tak terbatas)
		await Task.WhenAll(producerTask, consumerTask);
		Console.WriteLine("Finishhh");
	}
}
