using HouseEasy.Domain.Entities.Usuarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouseEasy.Data.Maps.Users
{
    public class UserMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            _ = builder.ToTable("Usuarios");
            _ = builder.HasKey(x => x.Id)
                       .HasName("PK_Usuarios");

            _ = builder.Property(x => x.Nome)
                       .HasColumnType("varchar")
                       .HasMaxLength(150);

            _ = builder.Property(x => x.Sobrenome)
                       .HasColumnType("varchar")
                       .HasMaxLength(150);

            _ = builder.Property(x => x.UserName)
                      .HasColumnType("varchar")
                      .HasMaxLength(255);
        }
    }
}
