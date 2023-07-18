// See https://aka.ms/new-console-template for more informationusing 
using System;
using System.Collections.Generic;
namespace Enumerator
{
	public class Program
	{
		static void Main(string[] args)
		{
			Enumeratorx enumeratorx = new Enumeratorx();
			foreach(string colours in enumeratorx)
			{
				Console.WriteLine(colours);
			}
		}
	}
}
