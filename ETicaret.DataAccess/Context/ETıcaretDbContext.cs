using ETicaret.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.DataAccess.Context;

public class ETıcaretDbContext : IdentityDbContext<AppUser,AppRole,Guid>
{
}
