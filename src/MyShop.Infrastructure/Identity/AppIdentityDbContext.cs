using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Infrastructure.Identity
{
	public sealed class AppIdentityDbContext : IdentityDbContext<ApplicationUser>
	{
		public AppIdentityDbContext(DbContextOptions options) : base(options)
		{
		}
	}
}
