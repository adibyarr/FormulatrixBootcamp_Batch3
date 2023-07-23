using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Enumerable
{


public class EnumerableProgram
{
	public class EnumerableSequence : IEnumerable<int>
	{
		private int count;
		public EnumerableSequence(int count)
		{
			this.count = count;
		}
		public IEnumerator<int>GetEnumerator()
		{
			int current = 0;
			int next = 1;
			
			for (int i = 0; i < count; i++)
			{
				yield return current;
				int temp = current;
				current = next;
				next = temp + next;
			}		
		}
		IEnumerator IEnumerable.GetEnumerator()
		
		{
			return GetEnumerator();
		}
	}
}
}