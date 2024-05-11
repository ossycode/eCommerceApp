
namespace eCommerce.Entities.CartEntities;

public class CartItem
{
	public int ItemId { get; set; }
	public int Quantity { get; set; }
	public decimal Price { get; set; }
	public decimal ProductTotal {
		get
		{
			return Price * Quantity;
		} }
}
