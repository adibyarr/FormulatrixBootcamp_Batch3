using System;

partial class Students
{
	private string name;
	private int age;
	
	public Students(string name, int age)
	{
		this.name = name;
		this.age = age;
	}
	public void DisplayInfo()
	{
		Console.WriteLine("Name: "+ name);
		Console.WriteLine("Age: " + age);
	}
}