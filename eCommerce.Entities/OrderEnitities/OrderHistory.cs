

namespace eCommerce.Entities.OrderEnitities;

public class OrderHistory : BaseEntity
{
	public int OrderId { get; set; }
	public int OrderStatus { get; set; }
	public string Note { get; set; }
}
