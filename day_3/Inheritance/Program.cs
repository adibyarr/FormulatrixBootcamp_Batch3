// See https://aka.ms/new-console-template for more informatio
using System;
namespace AbstractClass
{
	abstract class Animal
	{
			public abstract void MakeSound();
	}
	class Dog: Animal
	{
		public override void MakeSound()
		
		{
			Console.WriteLine("Bark Bark");
		}
	}
	class Program
	{
		static void Main()
		{
			Dog obj = new Dog();
			obj.MakeSound();
			
			Console.ReadLine();
		}
	}
}
