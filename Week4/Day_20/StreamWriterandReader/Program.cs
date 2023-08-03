using System; 
using System.IO;

class Program
{
	static void Main()
	{
		string fileName = "bootcamp.txt";
		string contentToWrite = "hellloooooooooooooooooooooo";
		string contentToAppend = "\nPenambahannnn content";
		
		string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
		
		if(File.Exists(filePath))
		{
			using(StreamReader reader = new StreamReader(filePath))
			{
				string contentRead = reader.ReadToEnd();
				Console.WriteLine("Content read dari file: ");
				Console.WriteLine(contentRead);
			}
		}
		else
		{
			Console.WriteLine("File nothinggg");
		}
		
		using(StreamWriter writer = new StreamWriter(filePath, false))
		{
			writer.Write(contentToWrite);
		}
		using(StreamWriter writer1 = new StreamWriter(filePath, true))
		{
			writer1.Write(contentToAppend);
		}
		
		if(File.Exists(filePath))
		{
			using (StreamReader reader = new StreamReader(filePath))
			{
				string contentRead = reader.ReadToEnd();
				Console.WriteLine("\nContent Read from file: ");
				Console.WriteLine(contentRead);
			}
		}
		else
		{
			Console.WriteLine("File Ga Ada");
		}
	}
}