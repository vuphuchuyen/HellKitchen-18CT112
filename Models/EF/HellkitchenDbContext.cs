using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;

namespace Models.EF
{
    public partial class HellkitchenDbContext : DbContext
    {
        public HellkitchenDbContext()
            : base("name=HellkitchenDbContext2")
        {
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

           
        }

       
    }
}
