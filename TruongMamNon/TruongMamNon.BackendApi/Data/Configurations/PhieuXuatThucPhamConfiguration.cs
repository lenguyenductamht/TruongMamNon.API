using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class PhieuXuatThucPhamConfiguration : IEntityTypeConfiguration<PhieuXuatThucPham>
    {
        public void Configure(EntityTypeBuilder<PhieuXuatThucPham> builder)
        {
            builder.ToTable("PhieuXuatThucPhams");
            builder.HasKey(x => x.MaPhieuXuatThucPham);
            builder.Property(x => x.NgayXuat).IsRequired();
            builder.Property(x => x.MaNguoiXuat).IsRequired();
            builder.Property(x => x.GhiChu).IsRequired(false);
            builder.Property(x => x.TrangThai).IsRequired();

            builder.HasOne(x => x.NguoiXuat).WithMany(x => x.PhieuXuatThucPhams).HasForeignKey(x => x.MaNguoiXuat);
        }
    }
}