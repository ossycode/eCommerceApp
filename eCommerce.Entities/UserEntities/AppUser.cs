using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using eCommerce.Entities.PictureEnitities;

namespace eCommerce.Entities.UserEntities;

public class AppUser : IdentityUser
{
	public string FullName { get; set; }
	public string Country { get; set; }
	public string City { get; set; }
	public string Address { get; set; }
	public string PostalCode { get; set; }
	public int? PictureId { get; set; }
	public virtual Picture Picture { get; set; }
	public DateTime? RegisteredOn { get; set; }

	public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<AppUser> userManager)
	{
		var userIdentity = new ClaimsIdentity();

		userIdentity.AddClaim(new Claim(ClaimTypes.NameIdentifier, Id));
		userIdentity.AddClaim(new Claim(ClaimTypes.Name, UserName));
		userIdentity.AddClaim(new Claim("Email", Email));
		userIdentity.AddClaim(new Claim("Picture", Picture != null ? Picture.URL : string.Empty));

		var roles = await userManager.GetRolesAsync(this);
		foreach (var role in roles)
		{
			userIdentity.AddClaim(new Claim(ClaimTypes.Role, role));
		}

		return userIdentity;
	}

	public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<AppUser>userManager, string authenticationType)
	{
		var userIdentity = new ClaimsIdentity(authenticationType);

		userIdentity.AddClaim(new Claim("Email", Email));
		userIdentity.AddClaim(new Claim("Picture", Picture != null ? Picture.URL : string.Empty));

		var roles = await userManager.GetRolesAsync(this);
		foreach (var role in roles)
		{
			userIdentity.AddClaim(new Claim(ClaimTypes.Role, role));
		}

		return userIdentity;
	}
}

