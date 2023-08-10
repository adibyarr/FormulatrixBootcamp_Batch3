Nnamespace BasketballPlayer;
public class Basketers

{
	private string _playerName;
	private int _playerAge;
	private string _club;
	
	public Basketers(string name, int age, string club)
	
	{
		_playerName = name;
		_playerAge = age;
		_club = club;
	}
	public string GetName()
	
	{
		return _playerName;
	}
	public int GetAge()
	
	{
		return _playerAge;
	}
	public string GetClub()
	
	{
		return _club;
	}
}