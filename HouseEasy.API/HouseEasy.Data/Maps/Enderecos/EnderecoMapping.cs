using HouseEasy.Domain.Entities.Enderecos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouseEasy.Data.Maps.TipoVendas
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            _ = builder.ToTable("Enderecos");

            _ = builder.HasKey(x => x.Id)
                       .HasName("PK_Enderecos");            

            _ = builder.Property(x => x.Bairro)
                        .HasColumnType("varchar")
                        .HasMaxLength(150).IsRequired();

            _ = builder.Property(x => x.CEP)
                       .HasColumnType("varchar")
                       .HasMaxLength(9).IsRequired();

            _ = builder.Property(x => x.Localidade)
                      .HasColumnType("varchar")
                      .HasMaxLength(250).IsRequired();

            _ = builder.Property(x => x.Complemento)
                      .HasColumnType("varchar")
                      .HasMaxLength(150).IsRequired();

            _ = builder.Property(x => x.Logradouro)
                      .HasColumnType("varchar")
                      .HasMaxLength(150).IsRequired();

            _ = builder.HasOne(x => x.Usuario)
                       .WithOne(x => x.Endereco)
                       .HasForeignKey<Endereco>(e => e.UsuarioId);
        }
    }
}
