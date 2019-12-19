using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace efcoreorderby
{
    public class EfCoreOrderByContext : DbContext
    {
        public DbSet<SimpleObject> SimpleObjects { get; set; }
        public EfCoreOrderByContext(DbContextOptions<EfCoreOrderByContext> options)
     : base(options)
        {
            //Database.EnsureCreated();
            if (Database.ProviderName != "Microsoft.EntityFrameworkCore.InMemory")
            {
                Database.EnsureCreated();
            }
        }


    }

    public class EfCoreOrderByContextFactory : IDesignTimeDbContextFactory<EfCoreOrderByContext>
    {
        public EfCoreOrderByContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EfCoreOrderByContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=simple_object;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new EfCoreOrderByContext(optionsBuilder.Options);
        }
    }
}
