namespace DesignPattern;

public class Program
{
	static void Main()
	{
		Television tv = new();
		TvOnCommand tvOn = new TvOnCommand(tv);
		TvOffCommand tvOff = new TvOffCommand(tv);
		TvChangeChannel changeChannel = new TvChangeChannel(tv, 7);
		
		RemoteControl remote = new RemoteControl();
		remote.SetCommand(tvOn);
		remote.PressButton();
		Console.WriteLine("Tv Nyalaa");
		
		remote.SetCommand(changeChannel);
		remote.PressButton();
		Console.WriteLine("Channel pindah ke 7");
		
		remote.SetCommand(tvOff);
		remote.PressButton();
		Console.WriteLine("Matiin TV");
	}
}