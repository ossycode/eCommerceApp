namespace eCommerce.Entities.Models;

public class OrderHistory : BaseModel
{
	public int OrderId { get; set; }
	public int OrderStatus { get; set; }
	public string Note { get; set; }
}
