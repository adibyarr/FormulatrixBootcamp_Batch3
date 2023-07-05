using DisplayLib;
class Program
{
	static void Main()
	{
		PlayerEdan child = new PlayerEdan();
		DefaultPlayer parent = child;
		
		child.Jump();
		parent.Jump();
		
		child.Run();
		parent.Run();
		
		child.Dunk();
		parent.Dunk();
		
	}
}