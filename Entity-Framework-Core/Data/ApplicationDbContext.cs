using Entity_Framework_Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Entity_Framework_Core.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<School> Schools => Set<School>();
        public DbSet<Teacher>  Teachers => Set<Teacher>();
        public DbSet<Dictionary<string,object>> Blogs => Set<Dictionary<string,object>>("Blog");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SharedTypeEntity<Dictionary<string, object>>("Blog", bb =>
            {
                bb.Property<int>("BlogId");
                bb.Property<string>("Name");
                bb.Property<DateTime>("LastUpdated");
            });
            modelBuilder.Entity<School>()
                .IndexerProperty<DateTime>("LastUpdated");
            base.OnModelCreating(modelBuilder);
        }
    }
}
