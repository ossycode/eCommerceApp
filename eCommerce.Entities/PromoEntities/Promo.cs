﻿

using System.ComponentModel.DataAnnotations;

namespace eCommerce.Entities.PromoEntities;

public class Promo : BaseEntity
{
	public string Name { get; set; }
	public string Description { get; set; }

	[StringLength(50)]
	public string Code { get; set; }
	public int PromoType { get; set; }
	public decimal Value { get; set; }
	public DateTime? ValidTill {  get; set; }
}
