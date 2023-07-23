using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static Enumerable.EnumerableProgram;

namespace Enumerable
{
	public class Program
	{
		static void Main(string[] args)
		{
			int count = 10;
			EnumerableSequence enumerableSequence = new EnumerableSequence(count);
			
			var evenEnumerable = enumerableSequence.Where(n => n % 2 ==0 );
			Console.WriteLine($"First{count} fibonnaci numbers: ");
			foreach(int numbers in enumerableSequence)
			{
				Console.WriteLine(numbers + " ");
			}
			Console.WriteLine("\n \nEven Enumerable numbers: ");
			foreach(int numbers in evenEnumerable)
			{
				Console.WriteLine(numbers + " ");
			}
			Console.ReadLine();
		}
	}
}
