namespace  BetterOODemo
{
	public class Truck : AutoMotive, IRental
	{
		public TruckType Style{get; set;}
		public int RentalId{get;set;}
		public string? CurrentRenter{get;set;}
		public decimal PricePerDay{get;set;}
	}
}