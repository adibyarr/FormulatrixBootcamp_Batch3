using System;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;

class program
{
	static void Main()
	{
		Console.WriteLine("===Constructing String===");
		string muray = "tweet sounds good";
		Console.WriteLine("muray.EndsWith('lovebird'): " + muray.EndsWith("good"));
		Console.WriteLine("muray.StartWith('fly): " + muray.StartsWith("tweet"));
		Console.WriteLine("muray.Contains('suu'): "+ muray.Contains("sou"));
		
		string textJorok = "%&^#abobasu kondna";
		Console.WriteLine("%&^#abob asu,kondna".IndexOfAny (new char[] {'a', ','}));
		Console.WriteLine("********************************\n\n");
		
		Console.WriteLine("******Empty String******");
		string EmptyString = string.Empty;
		string Hampa = string.Empty;
		string EmptyString2 = "";
		string Hampa2 = null;
		Console.WriteLine(EmptyString == EmptyString2);
		Console.WriteLine(EmptyString2 == " ");
		Console.WriteLine(EmptyString2 == "");
		Console.WriteLine(new string('*', 6));
		Console.WriteLine((new string ('*', 6).Length));
		
		byte[] bytes = new byte[8];
		bytes = BitConverter.GetBytes(123.145);
		foreach (var b in bytes)
		{
			Console.WriteLine(b + "");
		}
		Console.WriteLine("");
		
		double dbValuue = BitConverter.ToDouble(bytes, 0);
		Console.WriteLine(dbValuue);
		char[] chars = " adib ".ToCharArray();
		string s = new string(chars);
		System.Console.WriteLine(s);
		System.Console.WriteLine(chars[1]);
		System.Console.WriteLine(chars.Length);
		System.Console.WriteLine(s.Length);
		System.Console.WriteLine(EmptyString2.Length == 0);
		System.Console.WriteLine(Hampa == null);
		System.Console.WriteLine(Hampa2 == null);
		Console.WriteLine("***************\n");
		
		Console.WriteLine("***Access char w/ string****");
		Console.WriteLine(new string('a', 6));
		
		char[] chars1 = "Bootcamp".ToCharArray();
		foreach (var c in chars1)
		{
			System.Console.WriteLine(c);
		}
		for ( int i = 0; i < chars1.Length; i++)
		{
			System.Console.WriteLine(chars1[i]);
		}
		System.Console.WriteLine("******************* \n\n");
		
		Console.WriteLine ("quick brown fox".EndsWith ("fox")); // True
		Console.WriteLine ("quick brown fox".Contains ("brown")); // True
		//IndexOfAny returns the first matching position of any one of a set of characters:
		Console.Write ("ab,cd ef".IndexOfAny (new char[] {' ', ','} )); // 2
		Console.Write ("pas5w0rd".IndexOfAny ("0123456789".ToCharArray() )); // 3
		
		//Manipulating string
		Console.WriteLine("***Manipulating String***");
		string _= "		# 	anjae	# 	";
		System.Console.WriteLine(_);
		System.Console.WriteLine(_.Trim());
		System.Console.WriteLine(_.TrimStart());
		System.Console.WriteLine(_.TrimEnd());
		System.Console.WriteLine(_.PadRight(40, '*'));
		System.Console.WriteLine(_.ToLower());
		System.Console.WriteLine(_.ToUpper());
		System.Console.WriteLine(_.Substring(0, 10));	
		System.Console.WriteLine(_.ToUpperInvariant());
		System.Console.WriteLine(_.ToUpperInvariant());
		System.Console.WriteLine(_.Replace(" ", "&"));
	}
}