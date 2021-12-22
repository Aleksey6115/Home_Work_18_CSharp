using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace Home_Work_18.Model
{
    /// <summary>
    /// Контекст данных для таблицы Product
    /// </summary>
    public class ProductContext : DbContext
    {
        public ProductContext() : base ("connectionToProduct") { }

        public DbSet<Product> Products { get; set; }
    }
}
