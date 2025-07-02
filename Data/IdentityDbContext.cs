using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LabaIyo.Models;

namespace LabaIyo.Data
{
    public class IdentityDatabaseContext : IdentityDbContext<IdenUser>
    {
        public IdentityDatabaseContext(DbContextOptions<IdentityDatabaseContext> options) : base(options)
        {
        }

        public DbSet<IdenUser> identityDb {  get; set; }
    }
}
