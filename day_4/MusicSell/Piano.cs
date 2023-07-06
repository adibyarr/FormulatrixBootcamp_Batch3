namespace InterfaceMusic;
public class Piano : IPiano
{
	public string pianoBrand;
	public Piano(string pianoBrand)
	{
		this.pianoBrand = pianoBrand;
	}
	public void Tone()
	{
		Console.WriteLine(pianoBrand + "Tone kanee");
	}
	public void Chord()
	{
	
		Console.WriteLine(pianoBrand + "Chord indra lesmanaa");
	}
}