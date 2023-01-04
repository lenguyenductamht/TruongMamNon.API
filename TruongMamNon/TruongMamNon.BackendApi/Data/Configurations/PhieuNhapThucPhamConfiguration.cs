using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class PhieuNhapThucPhamConfiguration : IEntityTypeConfiguration<PhieuNhapThucPham>
    {
        public void Configure(EntityTypeBuilder<PhieuNhapThucPham> builder)
        {
            builder.ToTable("PhieuNhapThucPhams");
            builder.HasKey(x => x.MaPhieuNhapThucPham);
            builder.Property(x => x.NgayNhap).IsRequired();
            builder.Property(x => x.MaNguoiNhap).IsRequired();
            builder.Property(x => x.GhiChu).IsRequired(false);
            builder.Property(x => x.TrangThai).IsRequired();

            builder.HasOne(x => x.NguoiNhap).WithMany(x => x.PhieuNhapThucPhams).HasForeignKey(x => x.MaNguoiNhap);
        }
    }
}