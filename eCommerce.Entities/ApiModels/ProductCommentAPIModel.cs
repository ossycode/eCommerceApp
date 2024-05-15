namespace eCommerce.Entities.ApiModels;

public class ProductCommentApiModel
{
	public int Id { get; set; }
	public CommentProduct Product { get; set; }
	public DateTime TimeStamp { get; set; }
	public string UserId { get; set; }
	public string UserName { get; set; }
	public int Rating { get; set; }
	public string Text { get; set; }
	public int EntityId { get; set; }
}

public class CommentProduct
{
	public int ProductId { get; set; }
	public string ProductTitle { get; set; }
}