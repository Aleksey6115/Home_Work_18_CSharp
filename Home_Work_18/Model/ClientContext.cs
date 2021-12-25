using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Home_Work_18.Model
{
    /// <summary>
    /// Класс Context для Client
    /// </summary>
    public class ClientContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public ClientContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.
                ConnectionStrings["connectionToClient"].ToString());
        }
    }
}
