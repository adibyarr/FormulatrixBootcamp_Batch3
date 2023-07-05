// See https://aka.ms/new-console-template for more information
namespace InheritanceTutor;
class Parent

{
	public string? myString;
	public Parent(string myString)
	
	{
		myString ="parent";
	}
		public Parent()
	
	{
		myString = "Parent";
	}
		public void MyMethodParent()
		{
			Console.WriteLine("Parent.MyMethodParent");
		}		
}
class Child : Parent

{
	public string? myStringP;
	public Child(string y) : base(y)
	{
		myString = y;
	}
	public void MyMethodChild()
	
	{
		Console.WriteLine("Child.MyMethodChild");
	}
}
	

