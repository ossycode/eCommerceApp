namespace eCommerce.Entities.ApiModels;

public class ProductApiModel
{
	public int Id { get; set; }
	public int CategoryId { get; set; }
	public string Name { get; set; }
	public string Summary { get; set; }
	public string Description { get; set; }
	public decimal Price { get; set; }
	public decimal? Discount { get; set; }
	public decimal? Cost { get; set; }
	public bool IsFeatured { get; set; }
	public string SKU { get; set; }
	public string Tags { get; set; }
	public string Barcode { get; set; }
	public string Supplier { get; set; }
	public int StockQuantity { get; set; }
	public int TotalRatings { get; set; }
	public decimal AverageRatings { get; set; }
	public virtual List<ProductSpecificationApiModel> ProductSpecifications { get; set; }
	public virtual List<PictureApiModel> Pictures { get; set; }

}

public class ProductSpecificationApiModel
{
	public string Title { get; set; }
	public string Value { get; set; }
}