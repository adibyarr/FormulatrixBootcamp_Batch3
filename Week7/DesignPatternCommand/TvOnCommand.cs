namespace DesignPattern;

public class TvOnCommand : Command
{
	private Television _tv;
	public TvOnCommand(Television tv)
	{
		_tv = tv;
	}
    public override void Execute()
    {
        _tv.TurnOn();
    }
}