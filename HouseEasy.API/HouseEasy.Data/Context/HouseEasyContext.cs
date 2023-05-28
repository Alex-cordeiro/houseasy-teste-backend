using HouseEasy.Domain.Entities.Enderecos;
using HouseEasy.Domain.Entities.Ocupacoes;
using HouseEasy.Domain.Entities.Telefones;
using HouseEasy.Domain.Entities.Usuarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HouseEasy.Data.Context
{
    public class HouseEasyContext : DbContext
    {
        public HouseEasyContext()
        {
        }
        public HouseEasyContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<Ocupacao> Ocupacoes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=sqlserver;Database=houseEasyAPI;User Id=sa;Password=Testebackend2023");
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(HouseEasyContext).Assembly);
        }
    }
}
