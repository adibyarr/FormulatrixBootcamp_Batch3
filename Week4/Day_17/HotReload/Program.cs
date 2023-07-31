using System;
using System.Net.Http;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        await DoSomethingAsync();
    }

    public static async Task DoSomethingAsync()
    {
        Console.WriteLine("Before the async operation.");

        // Simulate an asynchronous operation, e.g., making an HTTP request.
        await Task.Delay(2000); // Pauses the execution for 2 seconds.

        Console.WriteLine("After the async.");
    }
}

