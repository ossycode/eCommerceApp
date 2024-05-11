
namespace eCommerce.Entities.CategoryEnitities;

public class CategoryWithChildren
{
	public Category Category { get; set; }
	public List<Category> Children { get; set; }
}
