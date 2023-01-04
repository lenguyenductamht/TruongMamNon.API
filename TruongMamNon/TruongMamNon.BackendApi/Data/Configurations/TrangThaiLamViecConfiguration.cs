using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class TrangThaiLamViecConfiguration : IEntityTypeConfiguration<TrangThaiLamViec>
    {
        public void Configure(EntityTypeBuilder<TrangThaiLamViec> builder)
        {
            builder.ToTable("TrangThaiLamViecs");
            builder.HasKey(x => x.MaTrangThai);
            builder.Property(x => x.MaTrangThai).IsRequired().HasMaxLength(1);
            builder.Property(x => x.TenTrangThai).IsRequired().HasMaxLength(50);
        }
    }
}