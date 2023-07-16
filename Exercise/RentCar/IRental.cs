// See https://aka.ms/new-console-template for more information
namespace BetterOODemo

{
    public interface IRental
	{
		int RentalId{get; set; }
		string? CurrentRenter{get; set;}
		 decimal PricePerDay{get; set;}
	}
}
