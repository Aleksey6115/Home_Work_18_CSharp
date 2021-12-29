using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HomeWork_18.Model
{
    internal class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductContext()
        {
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DBProduct1;Trusted_Connection=True;");
        }
    }
}
