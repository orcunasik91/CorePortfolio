using Microsoft.AspNetCore.Identity;

namespace CorePortfolio.Entities.Concrete;
public class AppUser : IdentityUser<int>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string ImageUrl { get; set; }
}