
namespace OOPDemo
{
public class RentalSailYacht : RentalVehicle
{
		public override void StartEngine()
		{
			throw new Exception("Gamau ah");
		}
		public override void StopEngine()
		{
			throw new Exception("Maunya stopp");
		}
		
	
}

public class  RentalVehicle
	{
		public int RentalId{get; set; }
		public string? CurrentRenter{get; set;}
		public decimal PricePerDay{get; set;}
		public int NumOfPassanger{get; set;}
		
		
		public virtual void StartEngine()
		{
			Console.WriteLine("Turn on setting");
			Console.WriteLine("Engine start");
		}
		public virtual void StopEngine()
		
		{
			Console.WriteLine("Engine stop");
		}
	}
}