﻿namespace eCommerce.Entities.ApiModels;

public class PromoApiModel
{
	public string Code { get; set; }
	public int PromoType { get; set; }
	public decimal Value { get; set; }
	public DateTime? ValidTill { get; set; }
}
