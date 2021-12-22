using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace Home_Work_18.Model
{
    /// <summary>
    /// Класс Context для Client
    /// </summary>
    public class ClientContext : DbContext
    {
        public ClientContext() : base("connectionToSql") { }
        public DbSet<Client> Clients { get; set; }
    }
}
