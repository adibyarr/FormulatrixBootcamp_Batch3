namespace DesignPattern;
public class TvOffCommand : ICommand

{
	private Television _tv;
	
	public TvOffCommand(Television television)
	{
		_tv = television;
	}
    public void Execute()
    {
        _tv.TurnOff();
    }
}