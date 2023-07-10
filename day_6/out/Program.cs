// See https://aka.ms/new-console-template for more information
class Program
{
	static void Main()
	{
		int number1 = 203;
		MultipleByAddTwo(ref number1, out int number2);
		Console.WriteLine(number1);
		Console.WriteLine(number2);
		
		int number3;
		FillNumber(out number3);
	}
	static void MultipleByAddTwo(ref int x, out int y)
	{
		y = 8;
		x = x + 1;
	}
	static void FillNumber(out int number3)
	
	{
		number3 = 3;
	}
}
