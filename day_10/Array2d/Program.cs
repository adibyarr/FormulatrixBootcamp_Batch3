using System;
using System.Collections.Generic;

namespace Array2D
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] RectangleArray = new int[3, 6];
			int a = 10;
			
			foreach (int i in RectangleArray)
			{
				Console.WriteLine(i + " ");
			}
			Console.WriteLine("\n");
			
			for (int i =0; i < RectangleArray.GetLength(0); i++)
			{
				for (int j = 0; j < RectangleArray.GetLength(1); j++)
				
				{
					a += 5;
					RectangleArray[i, j] = a;
				}
			}
			for (int i = 0; i < RectangleArray.GetLength(0); i++)
			{
				for (int j = 0; j < RectangleArray.GetLength(1); j++)
				{
					Console.WriteLine(RectangleArray[i, j] + " ");
				}
			}
			Console.ReadLine
			();
		}
	}
}