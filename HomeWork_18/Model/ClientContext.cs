using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace HomeWork_18.Model
{
    internal class ClientContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public ClientContext()
        {
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DBClient1;Trusted_Connection=True;");
        }

    }
}
