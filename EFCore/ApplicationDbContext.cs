using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<EntityA> AEntities { get; set; }
        public DbSet<EntityB> BEntities { get; set; }
        public DbSet<OtherEntity> OtherEntities { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        { }

    }
}
