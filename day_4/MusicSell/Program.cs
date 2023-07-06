// See https://aka.ms/new-console-template for more information
namespace InterfaceMusic;
class Program
{
	static void Main()
	{
		Drum drum = new ("Yudzian ");
		Guitar guitar = new("Gibson ");
		Piano piano = new ("Kort ");
		
		MusicStore musicStore = new MusicStore(drum, guitar, piano);
		
		drum.Kick();
		drum.Hit();
		drum.Snare();
		guitar.Chord();
		guitar.Pick();
		piano.Tone();
		piano.Chord();
		
		Console.ReadLine();
	}
}
