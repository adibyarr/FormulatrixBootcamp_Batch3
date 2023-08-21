namespace DesignPattern;

public class TvChangeChannel : ICommand
{
	private Television _tv;
	private int _changeChannel;
	
	public TvChangeChannel( Television television,int channel)
	{
		_tv = television;
		_changeChannel = channel;
	}
	public  void Execute()
	{
		_tv.ChangeChannel();
	}
}