using System;

/// <summary>
/// A simple calc class that performs basic operations
/// </summary>
namespace XMLDocs
{


	public class MyLib
	{
		///<summary>
		/// Add two integers and return the result
		/// </summary>
		///<param name= "a"> The first integer. </param>
		///<param name = "b"> The second integer. </param>
		///<returns> The sum of the integer. <//returns>

		public int Add(int a, int b)
		{
			return a + b;
		}

		///<summary> 
		/// substract two integers and return the result.
		///</summary>
		///<param name = "a"> First integer(minuend).</param>
		///<param name = "b"> Second integer(minuend).</param>
		///<return> The result of substraction.</returns>
	
		public int Substract(int a, int b)
		{
			return a - b;
		}
	}
}