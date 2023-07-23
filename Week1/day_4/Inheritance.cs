// See https://aka.ms/new-console-template for more information
namespace Inheritance
{
	

class Animal
{
	public void Eat()
	{
		Console.WriteLine("Animal is eating.");
	}
}
class Vehicle

{
	public void Drive()
	{
		Console.WriteLine("Vehicle is driving");
	}
}
interface IAccelerate
{
	void Accelerate()
}
class Car : Vehicle, IAccelerate
{
	public void Accelerate()
	{
		Console.WriteLine("Car is accelerating");
	}
}
}