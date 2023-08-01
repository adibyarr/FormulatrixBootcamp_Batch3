using System;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Start loading data...");

        // Menampilkan animasi loading menggunakan Task.Run
        var loadingTask = Task.Run(AnimateLoading);

        // Simulasi loading data
        await Task.Delay(5000); // Simulasi loading selama 5 detik

        // Menunggu animasi loading selesai
        await loadingTask;

        Console.WriteLine("Data loaded successfully.");
    }

    private static async Task AnimateLoading()
    {
        Console.CursorVisible = false;

        string animationFrames = "|/-\\";
        int frameIndex = 0;

        while (!Console.KeyAvailable)
        {
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
            Console.Write(animationFrames[frameIndex]);
            frameIndex = (frameIndex + 1) % animationFrames.Length;
            await Task.Delay(100);
        }

        // Clear the last frame of the animation
        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
        Console.Write(" ");
        Console.CursorVisible = true;
    }
}
