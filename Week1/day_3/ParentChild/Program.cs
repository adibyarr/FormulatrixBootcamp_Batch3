// See https://aka.ms/new-console-template for more information
using InheritanceTutor;

static class Program
{
	static void Main()
	{
		Parent parent = new Parent("LOLO");
		Child child = new Child("KOKOK");
		
		Console.WriteLine(parent.myString);
		Console.WriteLine(child.myString);
		parent.MyMethodParent();

		child.MyMethodParent();
		child.MyMethodChild();
		
	}
}