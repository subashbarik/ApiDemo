using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WebAPI.Data.Entity;

namespace WebAPI.Data
{
    public class DemoApiContext:DbContext
    {
        public DemoApiContext()
        {

        }
        public DemoApiContext(DbContextOptions<DemoApiContext> options) : base(options) { }
        public DbSet<Quote> Quotes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
