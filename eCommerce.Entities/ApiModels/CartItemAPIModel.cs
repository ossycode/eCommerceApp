namespace eCommerce.Entities.ApiModels;

public class CartItemApiModel
{
	public CartItemProduct Product { get; set; }
	public int Quantity { get; set; }
	public decimal Price { get; set; }
	public decimal ProductTotal
	{
		get
		{
			return Price * Quantity;
		}
	}

}

public class CartItemProduct
{
	public int Id { get; set; }
	public string Title { get; set; }
	public string Picture { get; set; }
}
