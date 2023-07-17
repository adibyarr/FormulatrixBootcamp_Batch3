namespace TaskFoobar
{
	class FoobarPrinter
	{
	   public void PrintNumbers(int n, Dictionary<int,string> rules)
		
		{
			for (int i = 0; i <= n; i++)
			{
				bool isDivided = false;
				string result = " ";
				
				foreach(var rule in rules)
				{
					if (i != 0 && i % rule.Key == 0)
					{
						result += rule.Value;
						isDivided = true;
					}
				}
				if (!isDivided)
				
					result += i.ToString();
					
					Console.Write(result+ " ");
				
			}
		}

	}
}