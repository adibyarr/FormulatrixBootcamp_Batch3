// See https://aka.ms/new-console-template for more information
namespace BasketballPlayer;

class Program 

{
	static void Main()
	
	{
		List<Basketers> Basketer = new List<Basketers>();
		Basketer.Add(new Basketers("James", 32, "Lakers"));
		Basketer.Add(new Basketers("Durant", 38,"Nets"));
		
		foreach(Basketers basketer in Basketer)
		
		{
			string NamePlayer = basketer.GetName();
			int AgePlayer = basketer.GetAge();
			string ClubPlayer = basketer.GetClub();
			Console.WriteLine($"Name:{NamePlayer}\n Age:{AgePlayer} \n Club:{ClubPlayer}\n");
		}
	}
}

