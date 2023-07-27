// See https://aka.ms/new-console-template for more information
using System;

class Program
{
	static void Main()
	{
		using(var fileStream = new System.IO.FileStream("contoh.txt", System.IO.FileMode.Create))
		{
			byte[] data =System.Text.Encoding.UTF8.GetBytes("Contoh teks yg ditulis kedalam file");
			fileStream.Write(data, 0, data.Length);
		}
		Console.ReadLine();
	}
}
