using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infrastructure.Context
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

        public DbSet<Domain.Entities.Task> Tasks { get; set; }

    }
}
