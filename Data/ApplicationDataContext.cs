using Microsoft.EntityFrameworkCore;
using PlatformSerice.Models;
namespace PlatformService.Data
{
    public class ApplicationDataContext: DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> dbContextOptions) : base(dbContextOptions) { }

        public DbSet<Platform> Platforms { get; set; }

    }
}
