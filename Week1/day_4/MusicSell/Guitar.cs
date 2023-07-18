namespace InterfaceMusic;

public class Guitar : IGuitar
{
	public string guitarBrand;
	public Guitar(string guitarBrand)
	{
		this.guitarBrand = guitarBrand;
	}
	public void Chord()
	{
		Console.WriteLine(guitarBrand + "Chord Guitar Run");
	}
	public void Pick()
	{
		Console.WriteLine(guitarBrand + "Pick Guitar Run");
	}
}