namespace ShoppingCart
{
	public class ShoppingCartModel
	{
		public List<ProductModel> Items {get; set;} = new List<ProductModel>();
		public decimal GenerateTotal()
		{
			decimal subTotal = Items.Sum(x => x.ItemPrice);
			if (subTotal > 100)
			{
				return subTotal * 0.08M;
			}
			else if (subTotal > 50)
			{
				return subTotal *0.05M;
			}
			else if ( subTotal > 10)
			{
				return subTotal * 0.03M;
			}
			else 
			
			{
				return subTotal;
			}
		}
	}
}