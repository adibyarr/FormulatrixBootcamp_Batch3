namespace InterfaceMusic;

public class Drum : IDrum, IGuitar
{
	public string drumBrand;
	public Drum(string drumBrand)
	{
		this.drumBrand = drumBrand;
	}
	public void Kick()
	{
		Console.WriteLine(drumBrand + "Kick drum edan");
	}
	public void Snare()
	{
		Console.WriteLine(drumBrand + "Snare drum edan");
	}
	public void Hit()
	{
		Console.WriteLine(drumBrand + "Hit Drum edann");
	}
	public void Chord()
	{
		Console.WriteLine(drumBrand + " Chord enak");
	}
	public void Pick()
	{
		Console.WriteLine(drumBrand + "Pick mantapp");
	}
}