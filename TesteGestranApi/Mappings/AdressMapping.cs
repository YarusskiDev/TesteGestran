using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteGestranApi.Models;

namespace TesteGestranApi.Mappings
{
    public class AdressMapping : IEntityTypeConfiguration<Adress>
    {
        public void Configure(EntityTypeBuilder<Adress> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Pais).IsRequired().HasColumnType("varchar(50)");

            builder.Property(x => x.Cep).IsRequired().HasColumnType("varchar(50)");

            builder.Property(x => x.Estado).IsRequired().HasColumnType("varchar(50)");

            builder.Property(x => x.Cidade).IsRequired().HasColumnType("varchar(50)");

            builder.Property(x => x.Rua).IsRequired().HasColumnType("varchar(50)");

            builder.Property(x => x.Numero).IsRequired().HasColumnType("int");

            builder.Property(x => x.Complemento).HasColumnType("varchar(50)");

            builder.HasMany(x => x.Provider).WithOne(x => x.Adress).HasForeignKey(x => x.Id_Adress);

            builder.ToTable("Adress");
        }
    }
}
