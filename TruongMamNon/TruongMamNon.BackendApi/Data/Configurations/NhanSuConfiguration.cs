using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class NhanSuConfiguration : IEntityTypeConfiguration<NhanSu>
    {
        public void Configure(EntityTypeBuilder<NhanSu> builder)
        {
            builder.ToTable("NhanSus");
            builder.HasKey(x => x.MaNhanSu);
            builder.Property(x => x.Ho).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Ten).IsRequired().HasMaxLength(200);
            builder.Property(x => x.MaGioiTinh).IsRequired().HasMaxLength(1);
            builder.Property(x => x.NgaySinh).IsRequired().HasMaxLength(200);
            builder.Property(x => x.NoiSinh).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.CMND).IsRequired().HasMaxLength(12);
            builder.Property(x => x.NgayCap).IsRequired(false);
            builder.Property(x => x.MaDanToc).IsRequired().HasMaxLength(3);
            builder.Property(x => x.MaTonGiao).IsRequired().HasMaxLength(3);
            builder.Property(x => x.MaQuocTich).IsRequired().HasMaxLength(3);
            builder.Property(x => x.NgayVaoTruong).IsRequired();
            builder.Property(x => x.MaPhongBan).IsRequired();
            builder.Property(x => x.MaTrangThaiLamViec).IsRequired();
            builder.Property(x => x.LyDoThoiViec).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.NgayCapNhat).IsRequired();
            builder.Property(x => x.MaLoaiNhanSu).IsRequired();
            builder.Property(x => x.MaChucVu).IsRequired(false);
            builder.Property(x => x.MaKhoiLop).IsRequired(false);
            builder.Property(x => x.SoDienThoai).IsRequired(false).HasMaxLength(15);
            builder.Property(x => x.Email).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.HoKhau).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.DiaChi).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.HinhAnh).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.MatKhau).IsRequired().HasMaxLength(200);
            builder.Property(x => x.MaTrangThaiTaiKhoan).IsRequired();

            builder.HasOne(x => x.LoaiNhanSu).WithMany(x => x.NhanSus).HasForeignKey(x => x.MaLoaiNhanSu);
            builder.HasOne(x => x.PhongBan).WithMany(x => x.NhanSus).HasForeignKey(x => x.MaPhongBan);
            builder.HasOne(x => x.ChucVu).WithMany(x => x.NhanSus).HasForeignKey(x => x.MaChucVu);
            builder.HasOne(x => x.KhoiLop).WithMany(x => x.NhanSus).HasForeignKey(x => x.MaKhoiLop);

            builder.HasOne(x => x.GioiTinh).WithMany(x => x.NhanSus).HasForeignKey(x => x.MaGioiTinh);
            builder.HasOne(x => x.DanToc).WithMany(x => x.NhanSus).HasForeignKey(x => x.MaDanToc);
            builder.HasOne(x => x.TonGiao).WithMany(x => x.NhanSus).HasForeignKey(x => x.MaTonGiao);
            builder.HasOne(x => x.QuocTich).WithMany(x => x.NhanSus).HasForeignKey(x => x.MaQuocTich);
            builder.HasOne(x => x.TrangThaiLamViec).WithMany(x => x.NhanSus).HasForeignKey(x => x.MaTrangThaiLamViec);
            builder.HasOne(x => x.TrangThaiTaiKhoan).WithMany(x => x.NhanSus).HasForeignKey(x => x.MaTrangThaiTaiKhoan);
        }
    }
}