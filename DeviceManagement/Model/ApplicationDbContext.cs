using Microsoft.EntityFrameworkCore;

namespace DeviceManagement.Model
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Import> Imports { get; set; }
        public DbSet<Device> Devices { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
