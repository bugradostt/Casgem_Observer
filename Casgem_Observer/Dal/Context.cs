using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Casgem_Observer.Dal
{
	public class Context : IdentityDbContext<AppUser, AppRole,int>
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=BUDOTEKNO\SQLEXPRESS; initial Catalog=CasgemObserverDb; integrated Security= true");
		}

        public DbSet<WelcomeMessage> WelcomeMessage { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<UserProcess> UserProcesses { get; set; }
	}
}
