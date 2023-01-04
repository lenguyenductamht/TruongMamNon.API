using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class VitaminConfiguration : IEntityTypeConfiguration<Vitamin>
    {
        public void Configure(EntityTypeBuilder<Vitamin> builder)
        {
            builder.ToTable("Vitamins");
            builder.HasKey(x => x.MaVitamin);
            builder.Property(x => x.TenVitamin).IsRequired().HasMaxLength(200);
            builder.Property(x => x.GhiChu).IsRequired(false);
        }
    }
}