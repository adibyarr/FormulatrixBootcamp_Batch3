using System;
class program
{
	static void Main()
	{
		double[] studentGrade = {85, 90, 86};
		Students students = new Students("Joko", 15, studentGrade);
		students.DisplayInfo();
		students.DisplayGrades();
		
		Console.ReadLine();
	}
}