using Domain.Classes;
using Microsoft.EntityFrameworkCore;

namespace Infra.Context
{
    public class LinhaContext : DbContext
    {
        public DbSet<Linha> Linha { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=my_host;Database=my_db;Username=my_user;Password=my_pw");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Linha>().ToTable("livro");
            modelBuilder.Entity<Linha>().HasKey(p => p.Id);
            modelBuilder.Entity<Linha>().HasKey(p => p.Nome);
            modelBuilder.Entity<Linha>().HasKey(p => p.Tarifa);
            modelBuilder.Entity<Linha>().HasKey(p => p.Origem);
            modelBuilder.Entity<Linha>().HasKey(p => p.Destino);
            modelBuilder.Entity<Linha>().HasKey(p => p.Numero);
            modelBuilder.Entity<Linha>().HasKey(p => p.LinhaMap);
        }

    }
}
