using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Entities.Models;

public class OrderItem : BaseModel
{
	public int OrderId { get; set; }

	[NotMapped]
	public string ProductName { get; set; }
	public int ProductId { get; set; }
	public virtual Product Product { get; set; }

	/// <summary>
	/// Item price is in Order Item because we can have a scenario where we might charge less or greater than the product Price.
	/// </summary>
	public decimal ItemPrice { get; set; }
	public int Quantity { get; set; }
}
