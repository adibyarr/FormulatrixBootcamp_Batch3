using System;
using System.Collections;
using System.Collections.Generic;
class Program
{
	static void Main()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(10);
		arrayList.Add("Hello");
		int num1 = (int) arrayList[0];
		string str1 = (string) arrayList[1];
		Console.WriteLine(num1);
		Console.WriteLine(str1);
		
		List<int> list = new List<int>();
		list.Add(32);
		
		int num2 = list[0];
		Console.WriteLine(num2);
	}
}