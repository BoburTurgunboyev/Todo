using Microsoft.EntityFrameworkCore;

namespace Toda.Api.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
        public DbSet<Task> Tasks { get; set; }  
    }
}
