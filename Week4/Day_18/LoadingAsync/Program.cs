using System;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Press Enter to stop loading and enter your input.");

        // Menampilkan animasi loading menggunakan Task.Run
        var loadingTask = Task.Run(AnimateLoading);

        // Menjalankan tugas membaca input secara asinkron
        Task<string> userInputTask = GetUserInputAsync();

        // Menunggu hingga salah satu dari tugas selesai
        await Task.WhenAny(userInputTask, loadingTask);

        // Jika tugas membaca input selesai lebih dulu, hentikan animasi loading
        if (loadingTask.Status == TaskStatus.Running)
        {
            StopAnimation();
        }

        // Ambil nilai input dari pengguna
        string userInput = await userInputTask;

        // Tampilkan input dari pengguna
        Console.WriteLine("Your input: " + userInput);
    }

    public static async Task<string> GetUserInputAsync()
    {
        return await Task.Run(() => Console.ReadLine());
    }

    private static async Task AnimateLoading()
    {
        Console.CursorVisible = false;

        string animationFrames = "|/-\\";
        int frameIndex = 0;

        while (true)
        {
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
            Console.Write(animationFrames[frameIndex]);
            frameIndex = (frameIndex + 1) % animationFrames.Length;

            if (Console.KeyAvailable)
            {
                break; // Hentikan animasi jika tombol telah ditekan
            }

            await Task.Delay(100);
        }

        // Clear the last frame of the animation
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
