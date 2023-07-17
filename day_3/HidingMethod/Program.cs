// See https://aka.ms/new-console-template for more information
class BaseClass
{
	public void MethodToHide()
	{
		Console.WriteLine("BaseClass - MethodToHide");
	}
}
class DerivedClass : BaseClass
{
	public new void MethodToHide()
	{
		Console.WriteLine("DerivedClass - MethodToHide");
	}
}
class Program
{
	static void Main()
	{
		BaseClass baseClass = new BaseClass();
		baseClass.MethodToHide();
		
		DerivedClass derivedClass = new DerivedClass();
		derivedClass.MethodToHide();
		
		BaseClass derivedClassAsBase = derivedClass;
		derivedClassAsBase.MethodToHide();
	}
}
