using HouseEasy.Domain.Entities.Ocupacao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouseEasy.Data.Maps.Ocupacoes
{
    public class OcupacoesMapping : IEntityTypeConfiguration<Ocupacao>
    {
        public void Configure(EntityTypeBuilder<Ocupacao> builder)
        {
            _ = builder.ToTable("Ocupacoes");
            _ = builder.HasKey(x => x.Id)
                       .HasName("PK_Ocupacoes");

            _ = builder.Property(x => x.Descricao)
                        .HasColumnType("varchar")
                        .HasMaxLength(250).IsRequired();

            _ = builder.Property(x => x.Cargo)
                        .HasColumnType("varchar")
                        .HasMaxLength(150).IsRequired();

            _ = builder.Property(x => x.CBO)
                         .HasColumnType("varchar")
                         .HasMaxLength(10).IsRequired();
        }
    }
}
