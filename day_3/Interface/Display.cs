namespace DisplayLib;
public interface IJump

{
	void Jump();
}
public interface IRun
{
	void Run();
}
public interface IDunk
{
	void Dunk();
}
public class DefaultPlayer: IJump, IRun

{
	public DefaultPlayer()
	{
		Console.WriteLine("Constructor Player");
	}
	public void Jump()
	{
		Console.WriteLine("DefaultPlayer Ngejump..");
	}
	public void Run()
	{
		Console.WriteLine("DefaultPlayer Ngerun..");
	}
	public virtual void Dunk()
	{
		Console.WriteLine("DefaultPlayer NgeDunk..");
	}
}
public class PlayerEdan : DefaultPlayer, IJump, IRun

{
public PlayerEdan()
	{
		Console.WriteLine("Constructo PlayerEdan");
	}
	public void Jump()
	{
		Console.WriteLine("PlayerEdan NgeJump..");
	}
	public void Run()
	{
		Console.WriteLine("PlayerEdan Ngerun..");
	}
	public override void Dunk()
	{
		Console.WriteLine("PlayerEdan Ngedunk..");
	}
}