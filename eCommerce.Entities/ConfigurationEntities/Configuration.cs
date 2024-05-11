using System.ComponentModel.DataAnnotations;

namespace eCommerce.Entities.ConfigurationEntities;

public class Configuration
{
	[Key]
	public string Key { get; set; }
	public string Value { get; set; }
	public string Description { get; set; }
	public int ConfigurationType { get; set; }
	public DateTime? ModifiedOn { get; set; }
}
