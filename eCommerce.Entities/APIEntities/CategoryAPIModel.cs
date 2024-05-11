
namespace eCommerce.Entities.APIEntities;

public class CategoryAPIModel
{
	public int Id { get; set; }
	public int? ParentCategoryId { get; set; }
	public string Name  { get; set; }
	public string Summary { get; set; }
	public string Description { get; set; }
	public bool IsFeatured { get; set; }
	public string SanitizedName { get; set; }
	public int DisplaySeqNo { get; set; }
	public int? PictureId { get; set; }
	public int ProductsCount { get; set; }
}
