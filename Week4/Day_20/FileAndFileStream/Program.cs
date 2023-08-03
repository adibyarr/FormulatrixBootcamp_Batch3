using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string fileName = "file.txt"; // File akan disimpan di direktori yang sama dengan executable
        string contentToWrite = "Hello, this is content to write using FileStream with different file modes!";

        // Menggabungkan direktori relatif dengan direktori saat ini untuk mendapatkan path lengkap
        string filePath = @"C:\Users\Batch 3\Bootcamp\day_Two\FormulatrixBootcamp_Batch3\Week4\Day_20\FileAndFileStream\file.txt";

        // CreateNew
        try
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.CreateNew, FileAccess.Write))
            {
                byte[] buffer = Encoding.UTF8.GetBytes(contentToWrite);
                fileStream.Write(buffer, 0, buffer.Length);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error creating file. Reason: {ex.Message}");
        }

        // Create
        using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        {
            byte[] buffer = Encoding.UTF8.GetBytes(contentToWrite);
            fileStream.Write(buffer, 0, buffer.Length);
        }

        // Open
        try
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[fileStream.Length];
                int bytesRead = fileStream.Read(buffer, 0, buffer.Length);
                string contentRead = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Content read from the file (Open mode):");
                Console.WriteLine(contentRead);
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Error opening file. Reason: {ex.Message}");
        }

        // OpenOrCreate
        using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
        {
            byte[] buffer = Encoding.UTF8.GetBytes(contentToWrite);
            fileStream.Write(buffer, 0, buffer.Length);
        }

        // Truncate 
        using (FileStream fileStream = new FileStream(filePath, FileMode.Truncate, FileAccess.Write))
        {
            byte[] buffer = Encoding.UTF8.GetBytes(contentToWrite);
            fileStream.Write(buffer, 0, buffer.Length);
        }

        // Append
        string contentToAppend = "\nAppend Filee	e.";
        using (FileStream fileStream = new FileStream(filePath, FileMode.Append, FileAccess.Write))
        {
            byte[] buffer = Encoding.UTF8.GetBytes(contentToAppend);
            fileStream.Write(buffer, 0, buffer.Length);
        }

        // Read content from the file using FileStream
        using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[fileStream.Length];
            int bytesRead = fileStream.Read(buffer, 0, buffer.Length);
            string contentRead = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            Console.WriteLine("\nFinal content read from the file (Open mode):");
            Console.WriteLine(contentRead);
        }
    }
}
