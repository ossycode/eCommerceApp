namespace eCommerce.Entities.Models;

public class LanguageResource : BaseModel
{
	public string Key { get; set; }
	public int LanguageId { get; set; }
	public string Value { get; set; }
}
