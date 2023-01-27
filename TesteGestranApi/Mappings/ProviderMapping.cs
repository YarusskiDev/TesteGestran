using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteGestranApi.Models;

namespace TesteGestranApi.Mappings
{
    public class ProviderMapping : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasColumnType("varchar(40)");

            builder.Property(x => x.Cnpj).IsRequired().HasColumnType("varchar(20)");

            builder.Property(x => x.Telephone).IsRequired().HasColumnType("varchar(25)");

            builder.Property(x => x.Email).IsRequired().HasColumnType("varchar(30)");
           
            builder.ToTable("Providers");
                
        }
    }
}
