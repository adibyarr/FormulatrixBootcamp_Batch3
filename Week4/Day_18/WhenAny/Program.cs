using System;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Start loading data...");

        // Menampilkan animasi loading menggunakan Task.Run
        var loadingTask = Task.Run(AnimateLoading);

        // Menjalankan tugas loading data secara asinkron
        Task<int[]> loadDataTask = LoadDataAsync();

        // Menunggu hingga salah satu dari tugas loading selesai
        await Task.WhenAny(loadDataTask, loadingTask);

        // Jika tugas data loading selesai lebih dulu, hentikan animasi loading
        if (loadingTask.Status == TaskStatus.Running)
        {
            StopAnimation();
        }

        // Menunggu tugas loading data selesai dengan await
        int[] data = await loadDataTask;

        // Menampilkan hasil data
        Console.WriteLine("Data loaded successfully:");
        foreach (int value in data)
        {
            Console.WriteLine(value);
        }
    }

    public static async Task<int[]> LoadDataAsync()
    {
        // Menggunakan Task.Delay untuk mensimulasikan loading data
        await Task.Delay(10000); // Simulasi loading selama 10 detik

        // Return data sebagai array integer (untuk contoh sederhana)
        return new int[] { 10, 20, 30 };
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
            await Task.Delay(200);
        }

        // Bersihkan animation frame
        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
        Console.Write(" ");
        Console.CursorVisible = true;
    }

    private static void StopAnimation()
    {
        Console.CursorVisible = true;
        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
        Console.Write(" "); // Clear the last frame of the animation
    }
}
