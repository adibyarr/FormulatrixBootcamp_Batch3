using System;
class Program
{
	static void Main()
	{
		DateTime date1 = new DateTime(2023, 8, 1, 9, 0, 0);
		DateTime date2 = new DateTime(2023, 8, 1, 6, 0, 0);
		
		TimeSpan timeDiff = date1 - date2;
		Console.WriteLine("Total minutes: {0}", timeDiff.TotalSeconds);
		
		DateTimeOffset wit = new DateTimeOffset(2023, 8, 1, 7, 0, 0, new TimeSpan(7, 0, 0));
		DateTimeOffset wib = new DateTimeOffset(2023, 8, 1, 6, 0, 0, new TimeSpan(9, 0, 0));
		
		TimeSpan timeDiff2 = wib - wit;
		Console.WriteLine("Total Hours: {0}", timeDiff2.TotalMinutes);
		
		TimeZoneInfo timeZone1 = TimeZoneInfo.FindSystemTimeZoneById("Eastern standard time");
		DateTimeOffset dto3 = TimeZoneInfo.ConvertTime(wib, timeZone1);
		Console.WriteLine("Before convert: {0}", timeZone1);
		Console.WriteLine("After convert: {0}", dto3);
	}
}
