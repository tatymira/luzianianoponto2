using Domain.Classes;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Context
{
    public class LinhaContext : DbContext
    {
        public DbSet<Linha> Linha { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=my_host;Database=my_db;Username=my_user;Password=my_pw");
        }
    }
}
