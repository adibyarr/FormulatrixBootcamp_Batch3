using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskFoobar
{
	class FoobarPrinter
	{
		private Dictionary<int, string> rules = new Dictionary<int, string>();

		public FoobarPrinter()
		{

			rules.Add(3, "foo");
			rules.Add(5, "bar");
			rules.Add(2, "fizz");
			rules.Add(4, "buzz");
		}

		public void AddRule(int divisor, string output)
		{
			rules[divisor] = output;
		}

		public void RemoveRule(int divisor)
		{
			rules.Remove(divisor);
		}

		public void RemoveAllRules()
		{
			rules.Clear();
		}

		public void PrintNumbers(int n)
		{
			for (int i = 1; i <= n; i++)
			{
				bool isDivided = false;
				string result = " ";

				foreach (var rule in rules.OrderBy(r => r.Key))
				{
					if (i % rule.Key == 0)
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
