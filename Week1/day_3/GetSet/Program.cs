// See https://aka.ms/new-console-template for more information
namespace TempeTahu
{
	public class Tahuuuu
	
	{
		public string Brand;
		public string Model{get; set;}
		public int Year{get; set;}
		public string Colour{get; set;}
		
		public Tahuuuu(string brand, string model, int year, string colour)
		{
			Brand = brand;
			Model = model;
			Year = year;
			Colour = colour;
		}
		public void Start()
		{
			Console.WriteLine($"Showing the {Brand} {Model}");
		}
	}
	class Program
	{
		static void Main()
		
		{
			Tahuuuu myTahuu = new Tahuuuu("TahuBakso", "Maicih", 2009, "kuning");
			
			Console.WriteLine($"My Tahu is a {myTahuu.Year} {myTahuu.Brand} {myTahuu.Model} in {myTahuu.Colour} colour.");
			myTahuu.Start();
		}
	}
}
