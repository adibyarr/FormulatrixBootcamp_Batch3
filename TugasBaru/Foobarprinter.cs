using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Linq;
=======
using System.Security;
>>>>>>> de4a01b0aceb4ef325ca415f50c033e43dca8f7f

namespace TaskFoobar
{
	class FoobarPrinter
	{
		private Dictionary<int, string> rules = new Dictionary<int, string>();
<<<<<<< HEAD

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
=======
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
>>>>>>> de4a01b0aceb4ef325ca415f50c033e43dca8f7f

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
