using Microsoft.AspNetCore.Identity;

namespace ETicaret.Entities.Concrete;

public class AppUser : IdentityUser<Guid>
{
    public string Name { get; set; }
    public string Surname { get; set; }
}
