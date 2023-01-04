using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class ChiTietPhieuXuatThucPhamConfiguration : IEntityTypeConfiguration<ChiTietPhieuXuatThucPham>
    {
        public void Configure(EntityTypeBuilder<ChiTietPhieuXuatThucPham> builder)
        {
            builder.ToTable("ChiTietPhieuXuatThucPhams");
            builder.HasKey(x => new { x.MaPhieuXuatThucPham, x.MaThucPham });
            builder.Property(x => x.DonGia).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(x => x.SoLuong).IsRequired();

            builder.HasOne(x => x.ThucPham).WithMany(x => x.ChiTietPhieuXuatThucPhams).HasForeignKey(x => x.MaThucPham);
            builder.HasOne(x => x.PhieuXuatThucPham).WithMany(x => x.ChiTietPhieuXuatThucPhams).HasForeignKey(x => x.MaPhieuXuatThucPham);
        }
    }
}