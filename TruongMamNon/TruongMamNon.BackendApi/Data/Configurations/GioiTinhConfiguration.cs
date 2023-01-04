using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class GioiTinhConfiguration : IEntityTypeConfiguration<GioiTinh>
    {
        public void Configure(EntityTypeBuilder<GioiTinh> builder)
        {
            builder.ToTable("GioiTinh");
            builder.HasKey(x => x.MaGioiTinh);
            builder.Property(x => x.MaGioiTinh).IsRequired().HasMaxLength(1);
            builder.Property(x => x.TenGioiTinh).IsRequired().HasMaxLength(5);
        }
    }
}