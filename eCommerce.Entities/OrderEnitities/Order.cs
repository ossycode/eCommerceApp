using eCommerce.Entities.PromoEntities;

namespace eCommerce.Entities.OrderEnitities;

public class Order : BaseEntity
{
	public string CustomerId { get; set; }
	public string CustomerName { get; set; }
	public string CustomerEmail { get; set; }
	public string CustomerPhone { get; set; }
	public string CustomerCity { get; set; }
	public string CustomerAddress { get; set; }
	public string CustomerPostalCode { get; set; }
	public string CustomerCountry { get; set; }
	public string OrderCode { get; set; }
	public int PaymentMethod { get; set; }
	public decimal TotalAmount { get; set; }
	public decimal Discount { get; set; }
	public decimal DeliveryCharges { get; set;}
	public decimal FinalAmount { get;set; }
	public DateTime PlacedOn { get; set; }
	public string TransactionId { get; set; }
	public bool IsGuestOrder { get; set; }
	public int? PromoId { get; set; }
	public virtual Promo Promo { get; set; }
	public virtual List<OrderItem> OrderItems { get; set; }
	public virtual List<OrderHistory> OrderHistory { get; set; }

}
