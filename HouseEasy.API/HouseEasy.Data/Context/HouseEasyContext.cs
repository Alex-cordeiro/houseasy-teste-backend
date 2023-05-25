using HouseEasy.Domain.Entities.Enderecos;
using HouseEasy.Domain.Entities.Ocupacao;
using HouseEasy.Domain.Entities.Telefones;
using HouseEasy.Domain.Entities.Usuarios;
using Microsoft.EntityFrameworkCore;

namespace HouseEasy.Data.Context
{
    public class HouseEasyContext : DbContext
    {
        public HouseEasyContext(DbContextOptions options) : base(options)
        {
        }

        protected HouseEasyContext()
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<Ocupacao> Ocupacao { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 31));
            if (!optionsBuilder.IsConfigured)
            {

                //optionsBuilder.UseMySql("server=gcom:46033;user=root;password=AlQ&@174mLh!2020@;database=supersistema", serverVersion,
                //    options => options.EnableRetryOnFailure());

                var connectionString = "Server=localhost:4433;DataBase=HouseEasy;Uid=administrator;Pwd=M3r1d14n!";

                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(HouseEasyContext).Assembly);
        }
    }
}
