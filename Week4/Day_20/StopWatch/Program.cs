using System;
using System.Diagnostics;
using System.IO;
using System.Text;

class Program 
{
	static void Main()
	{
		string filePath = @"C:\Users\Batch 3\Bootcamp\day_Two\FormulatrixBootcamp_Batch3\Week4\Day_20\StopWatch\stopwatch.txt";
		
		string dataToWrite = GenerateSampleData();	
		
		Stopwatch stopwatch = new();
		
		byte[] buffer = Encoding.UTF8.GetBytes(dataToWrite);
		
		stopwatch.Start();
		using (FileStream fileStream = new(filePath, FileMode.Create, FileAccess.Write))
		{
			fileStream.Write(buffer, 0, buffer.Length);	
		}
		
		stopwatch.Stop();
		Console.WriteLine("Data suksesss");
		
		byte[] readBuffer;
		stopwatch.Restart();
		using (FileStream fileStream1 = new FileStream(filePath, FileMode.Open, FileAccess.Read))
		{
			readBuffer = new byte[fileStream1.Length];
			fileStream1.Read(buffer, 0, readBuffer.Length);
		}
		stopwatch.Stop();
		
		string dataToRead = Encoding.UTF8.GetString(readBuffer);
		Console.WriteLine("Data suksess jugaa");
		Console.WriteLine($"Data yang dibutuhkan: {stopwatch.ElapsedMilliseconds} milis");
	}
	static string GenerateSampleData()
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i =0; i < 10000; i++)
		{
			stringBuilder.AppendLine($"Sample Data {i}");
		}
		return stringBuilder.ToString();
	}
}