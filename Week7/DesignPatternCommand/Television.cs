namespace DesignPattern;

public class Television
{
	private string? _on;
	private string? _off;
	private int _changeChannel;
	public string? TurnOn()
	{
		return _on;
	}
	public string? TurnOff()
	{
		return _off;
	}
	public int ChangeChannel()
	{
		return _changeChannel;
	}
}