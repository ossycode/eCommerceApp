namespace eCommerce.Entities.Models;

public class BaseModel
{
	public int Id { get; set; }
	public bool IsActive { get; set; }
	public bool IsDeleted { get; set; }
	public DateTime? ModifiedOn { get; set; }
}
