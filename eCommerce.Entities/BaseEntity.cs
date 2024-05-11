
namespace eCommerce.Entities;

public class BaseEntity
{
	public int Id { get; set; }
	public bool IsActive { get; set; }
	public bool IsDeleted { get; set; }
	public DateTime? ModifiedOn { get; set; }
}
