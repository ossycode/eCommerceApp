﻿namespace eCommerce.Entities.Models;

public class NewsletterSubscription
{
	public string EmailAddress { get; set; }
	public bool IsVerified { get; set; }
	public string UserId { get; set; }
}
