

namespace eCommerce.Entities.ProductEnitities;

public class ProductSpecification : BaseEntity
{
	public int ProductRecordId { get; set; }
	public string Title { get; set; }
	public string Value { get; set; }
}

//public enum ProductSpecifications
//{
//	Brand = 1,
//	Model = 2,
//	Material = 3,
//	Color = 4,
//	Weigth = 5,
//	Shape = 6,
//	Size = 7,
//	Dimensions = 8,
//	Height = 9,
//	Length = 10,
//}
