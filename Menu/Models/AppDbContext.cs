using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Menu.Models
{

    
        public class ApplicationDbContext : DbContext
        {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Intial Catalog=RestDb;Integrated Security=True;")
        }


        public DbSet<Customer> Customers { get; set; }
            public DbSet<Menu> Menus { get; set; }
            public DbSet<Category> Categories { get; set; }
            public DbSet<Item> Items { get; set; }
            public DbSet<VariantHeader> VariantHeaders { get; set; }
            public DbSet<VariantDetail> VariantDetails { get; set; }
            public DbSet<ItemVariantDetailRel> ItemVariantDetailRels { get; set; }
        }
}
