using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Entities.Models;

public class Comment : BaseModel
{
	public DateTime TimeStamp { get; set; }
	public string UserId { get; set; }
	public virtual AppUser User { get; set; }
	public int Rating { get; set; }
	public string Text { get; set; }
	public int EntityId { get; set; }
	public int RecordId { get; set; }
	public int LanguageId { get; set; }
}
