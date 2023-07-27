// See https://aka.ms/new-console-template for more information
using System;
namespace DisposePattern
{


class Program
{
	static void Main()
	{
		using (Resource resource = new Resource())
		{
				resource.DoSomething();
		}
	}
}
}