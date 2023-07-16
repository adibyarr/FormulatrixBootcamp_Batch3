// See https://aka.ms/new-console-template for more information
namespace ShoppingCart
{
	public class Program
	{
		static ShoppingCartModel cart = new ShoppingCartModel(); 
		static void Main(string[] args)
		{
			PopulateCartWithDemoData();
			Console.WriteLine($"The total cart from is: {cart.GenerateTotal():C2}");
			
			Console.WriteLine();
			Console.Write("Press any key to continue");
			Console.ReadKey();
		}
		private static void PopulateCartWithDemoData()
		{
			cart.Items.Add(new ProductModel {ItemName = "Biskuit", ItemPrice = 20M});
			cart.Items.Add(new ProductModel {ItemName = "Coklat", ItemPrice = 12M});
			cart.Items.Add(new ProductModel {ItemName = "Pewangi", ItemPrice = 4M}); 
		}
	}
}
