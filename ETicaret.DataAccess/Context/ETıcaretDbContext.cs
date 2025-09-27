using ETicaret.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ETicaret.DataAccess.Context;

public class ETıcaretDbContext : IdentityDbContext<AppUser,AppRole,Guid>
{
}
