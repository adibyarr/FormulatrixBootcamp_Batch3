namespace DesignPattern;
public class TvOffCommand : Command

{
	private Television _tv;
	
	public TvOffCommand(Television television)
	{
		_tv = television;
	}
    public override void Execute()
    {
        _tv.TurnOff();
    }
}