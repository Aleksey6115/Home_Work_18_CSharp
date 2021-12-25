using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Home_Work_18.Model
{
    /// <summary>
    /// Контекст данных для таблицы Product
    /// </summary>
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.
                            ConnectionStrings["connectionToProduct"].ToString());
        }
    }
}
