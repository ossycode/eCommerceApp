namespace eCommerce.Entities.Models;

public class ProductPicture : BaseModel
{
	public int ProductId { get; set; }
	public int ProductPictureId { get; set; }
	public virtual Picture Picture { get; set; }
}
