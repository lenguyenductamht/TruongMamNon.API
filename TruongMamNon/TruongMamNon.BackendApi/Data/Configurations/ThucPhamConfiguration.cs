using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class ThucPhamConfiguration : IEntityTypeConfiguration<ThucPham>
    {
        public void Configure(EntityTypeBuilder<ThucPham> builder)
        {
            builder.ToTable("ThucPhams");
            builder.HasKey(x => x.MaThucPham);
            builder.Property(x => x.TenThucPham).IsRequired().HasMaxLength(200);
            builder.Property(x => x.DonViTinh).IsRequired();
            builder.Property(x => x.TonKho).IsRequired();
            builder.Property(x => x.MaDanhMuc).IsRequired();

            builder.HasOne(x => x.DanhMucThucPham).WithMany(x => x.ThucPhams).HasForeignKey(x => x.MaDanhMuc);
        }
    }
}