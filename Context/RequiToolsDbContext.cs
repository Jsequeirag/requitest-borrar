using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using requitools_be.Entities;
using System.Reflection.Metadata;

namespace requitools_be.Context
{
    public class RequiToolsDbContext:DbContext
    {

        public RequiToolsDbContext(DbContextOptions<RequiToolsDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            //para que no de problemas el FrameworkEntity con Identity
           base.OnModelCreating(modelBuilder);
          
            modelBuilder.Entity<View1>().HasNoKey().ToView(null);
           

        }


        public DbSet<Autores> Autores { get; set; }
        public DbSet<View1> View1 { get; set; }
    }
}
