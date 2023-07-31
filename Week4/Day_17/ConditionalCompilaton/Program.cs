#define RELEASE


using System;
class Program
{
	static void Main()
	{
		
		#if DEBUG
			Console.WriteLine("Production");
		
		#else
			Console.WriteLine("Notfound.");
		
		#endif 
	
	}
}