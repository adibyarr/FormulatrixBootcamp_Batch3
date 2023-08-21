namespace DesignPattern;

public class TvOnCommand : ICommand
{
	private Television _tv;
	public TvOnCommand(Television tv)
	{
		_tv = tv;
	}
    public void Execute()
    {
        _tv.TurnOn();
    }
}