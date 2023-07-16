using System;

partial class Students
{
	private double[] grades;
	public Students(string name, int age, double[] grades) : this(name,age)
	{
		this.grades = grades;
	}
	public void DisplayGrades()
	{
		Console.WriteLine("Grades: ");
		foreach(var grade in grades)
		{
			Console.WriteLine(grade);
		}
	}
}