using System;


namespace EnumProgram
{
	public enum TypeSending
	{
		Delivered,
		Shipping,
		Ordered,
		Unpaid
	}

	public class Program
	{
		public static void Main()
		{
			// Access enum values
		   	TypeSending today = TypeSending.Delivered;
			Console.WriteLine($"Today is {today}");

			// Enum iteration
			foreach (TypeSending day in Enum.GetValues(typeof(TypeSending)))
			{
				Console.WriteLine(day);
			}

			// Convert string to enum
			string input = "Wednesday";
			if (Enum.TryParse(input, out TypeSending parsedDay))
			{
				Console.WriteLine($"Parsed day: {parsedDay}");
			}
			else
			{
				Console.WriteLine("Invalid day");
			}

			// Wait for user input to exit
			Console.ReadLine();
		}
	}
}
