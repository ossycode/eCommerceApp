﻿using eCommerce.Entities.ProductEnitities;

namespace eCommerce.Entities.CategoryEnitities;

public class Category : BaseEntity
{
	public int? ParentCategoryId { get; set; }
	public virtual Category ParentCategory { get; set; }
	public bool IsFeatured { get; set; }
	public string SanitizedName { get; set; }
	public int DisplaySeqNo { get; set; }
	public int? PictureId { get; set; }
	public virtual List<Product> Products { get; set; }
	public virtual List<CategoryRecord> CategoryRecords { get; set; }
}

public class CategoryRecord : BaseEntity
{
	public int CategoryId { get; set; }
	public virtual Category Category { get; set; }
	public int LanguageId { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public string Summary { get; set; }
}