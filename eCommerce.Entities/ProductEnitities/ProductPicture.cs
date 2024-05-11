using eCommerce.Entities.PictureEnitities;

namespace eCommerce.Entities.ProductEnitities;

public class ProductPicture : BaseEntity
{
	public int ProductId { get; set; }
	public int ProductPictureId { get; set; }
	public virtual Picture Picture { get; set; }
}
