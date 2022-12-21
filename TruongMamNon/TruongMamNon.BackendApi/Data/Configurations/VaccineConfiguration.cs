using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class VaccineConfiguration : IEntityTypeConfiguration<Vaccine>
    {
        public void Configure(EntityTypeBuilder<Vaccine> builder)
        {
            builder.ToTable("Vaccines");
            builder.HasKey(x => x.MaVaccine);
            builder.Property(x => x.TenVaccine).IsRequired().HasMaxLength(200);
            builder.Property(x => x.GhiChu).IsRequired(false);
        }
    }
}