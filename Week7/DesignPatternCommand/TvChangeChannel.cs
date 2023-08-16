namespace DesignPattern;

public class TvChangeChannel : Command
{
	private Television _tv;
	private int _changeChannel;
	
	public TvChangeChannel( Television television,int channel)
	{
		_tv = television;
		_changeChannel = channel;
	}
	public override void Execute()
	{
		_tv.ChangeChannel();
	}
}