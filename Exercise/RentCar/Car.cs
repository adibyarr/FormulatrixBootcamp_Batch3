// See https://aka.ms/new-console-template for more information
namespace BetterOODemo
{
	public class Car : Automotive, IRental
	{
		public CarType Style{get; set;}
		public int RentalId{get; set;}
		public string? CurrentRenter{get; set;}
		public decimal PricePerDay{get; set;}
	}

    public class Automotive
    {
    }
}