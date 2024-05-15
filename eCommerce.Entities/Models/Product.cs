namespace eCommerce.Entities.Models;

public class Product : BaseModel
{
	public int CategoryId { get; set; }
	public decimal? Discount { get; set; }
	public decimal? Cost { get; set; }
	public bool IsFeatured { get; set; }
	public int ThumbnailPictureId { get; set; }
	public string SKU { get; set; }
	public string Tags { get; set; }
	public string Barcode { get; set; }
	public string Supplier { get; set; }
	public int StockQuantity { get; set; }
	public virtual List<ProductPicture> ProductPictures { get; set; }
	public virtual List<ProductRecord> ProductRecords { get; set; }
}

public class ProductRecord : BaseModel
{
	public int ProductId { get; set; }
	public virtual Product Product { get; set; }
	public int LanguageId { get; set; }
	public string Name { get; set; }
	public string Summary { get; set; }
	public string Description { get; set; }
	public virtual List<ProductSpecification> ProductSpecifications { get; set; }
}