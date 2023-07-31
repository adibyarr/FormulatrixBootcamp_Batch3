using System;
namespace XMLDocs
{
	class Program
	{
		static void Main()
		{
			MyLib myLib = new MyLib();
			
			int sum = myLib.Add(9, 4);
			int difference = myLib.Substract(12, 8);
			
			Console.WriteLine($"Sum: {sum}");
			Console.WriteLine($"result difference: {difference}");
		}
	}
}
