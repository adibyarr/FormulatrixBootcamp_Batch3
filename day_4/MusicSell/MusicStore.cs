namespace InterfaceMusic;

public class MusicStore
{
	public IDrum drum;
	public IGuitar guitar;
	public IPiano piano;
	public MusicStore(IDrum drum, IGuitar guitar, IPiano piano)
	{
		this.drum = drum;
		this.guitar = guitar;
		this.piano = piano;
	}
}
