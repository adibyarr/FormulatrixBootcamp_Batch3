// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace OperatorOverloading
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Vector v1 = new Vector(2, 3);
			Vector v2 = new Vector(4, 5);
			
			Vector sum = (v1 + v2);
			Console.WriteLine("sum: " + sum);
			Console.WriteLine("Are v1 and v2 are equal? "+ (v1==v2));
			Console.ReadLine();
		}
	}
}