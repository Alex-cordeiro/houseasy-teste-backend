using HouseEasy.Domain.Entities.Enderecos;
using HouseEasy.Domain.Entities.Telefones;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouseEasy.Data.Maps.Tamanhos
{
    public class TelefoneMapping : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            _ = builder.ToTable("Telefones");
            _ = builder.HasKey(x => x.Id)
                       .HasName("PK_Telefones");

            _ = builder.Property(x => x.Celular)
                        .HasColumnType("varchar")
                        .HasMaxLength(15).IsRequired();

            _ = builder.Property(x => x.Fixo)
                        .HasColumnType("varchar")
                        .HasMaxLength(15).IsRequired();

            _ = builder.Property(x => x.IsWhatsApp).IsRequired();

            _ = builder.HasOne(x => x.Usuario)
                       .WithOne(x => x.Telefone)
                       .HasForeignKey<Telefone>(e => e.UsuarioId);
        }
    }
}
