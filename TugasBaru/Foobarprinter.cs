using System;
using System.Collections.Generic;
using System.Security;

namespace TaskFoobar
{
	class FoobarPrinter
	{
		private Dictionary<int, string> rules = new Dictionary<int, string>();
		public FoobarPrinter()
		{
			rules.Add(3, "foo");
			rules.Add(5, "bar");
		}
		public void AddRule(int divisor, string output)
		{
			rules[divisor] = output; 
		}
		public void PrintNumbers(int n)
		{
			for (int i = 0; i <= n; i++) 
			{
				bool isDivided = false;
				string result = " ";

				foreach (var rule in rules)
				{
					if (i != 0 && i % rule.Key == 0)
					{
						result += rule.Value;
						isDivided = true;
					}
				}

				if (!isDivided)
					result += i.ToString();

				Console.Write(result + " ");
			}
		}
	}

}
