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

            builder.Property(x => x.Country).IsRequired().HasColumnType("varchar(50)");

            builder.Property(x => x.ZipCode).IsRequired().HasColumnType("varchar(50)");

            builder.Property(x => x.State).IsRequired().HasColumnType("varchar(50)");

            builder.Property(x => x.City).IsRequired().HasColumnType("varchar(50)");

            builder.Property(x => x.Street).IsRequired().HasColumnType("varchar(50)");

            builder.Property(x => x.Number).IsRequired().HasColumnType("int");

            builder.Property(x => x.Complement).HasColumnType("varchar(50)");

            builder.ToTable("Adress");
        }
    }
}
