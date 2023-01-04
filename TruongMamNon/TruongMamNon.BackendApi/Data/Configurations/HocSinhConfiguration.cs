using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class HocSinhConfiguration : IEntityTypeConfiguration<HocSinh>
    {
        public void Configure(EntityTypeBuilder<HocSinh> builder)
        {
            builder.ToTable("HocSinhs");
            builder.Property(x => x.Id).IsRequired();
            builder.HasKey(x => x.MaHocSinh);
            builder.Property(x => x.Ho).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Ten).IsRequired().HasMaxLength(200);
            builder.Property(x => x.MaGioiTinh).IsRequired().HasMaxLength(1);
            builder.Property(x => x.MaKhoiLop).IsRequired();
            builder.Property(x => x.MaLopHoc).IsRequired(false);
            builder.Property(x => x.NgayNhapHoc).IsRequired();
            builder.Property(x => x.MaTrangThaiHoc).IsRequired().HasMaxLength(1);
            builder.Property(x => x.LyDoNghiHoc).IsRequired(false);
            builder.Property(x => x.NgayCapNhat).IsRequired(false);
            builder.Property(x => x.NgaySinh).IsRequired();
            builder.Property(x => x.NoiSinh).IsRequired(false);
            builder.Property(x => x.MaDanToc).IsRequired(false).HasMaxLength(3);
            builder.Property(x => x.MaTonGiao).IsRequired(false).HasMaxLength(3);
            builder.Property(x => x.MaQuocTich).IsRequired(false).HasMaxLength(3);
            builder.Property(x => x.GhiChu).IsRequired(false);
            builder.Property(x => x.HoKhau).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.DiaChi).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.MatKhau).IsRequired().HasMaxLength(200);
            builder.Property(x => x.MaTrangThaiTaiKhoan).IsRequired().HasMaxLength(1);
            builder.Property(x => x.HinhAnh).IsRequired(false);
            builder.Property(x => x.HoTenPhuHuynh).IsRequired().HasMaxLength(200);
            builder.Property(x => x.NamSinhPhuHuynh).IsRequired(false).HasMaxLength(4);
            builder.Property(x => x.CMNDPhuHuynh).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.SDTPhuHuynh).IsRequired(false).HasMaxLength(15);
            builder.Property(x => x.NgheNghiepPhuHuynh).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.EmailPhuHuynh).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.DiaChiPhuHuynh).IsRequired(false).HasMaxLength(200);

            builder.HasOne(x => x.KhoiLop).WithMany(x => x.HocSinhs).HasForeignKey(x => x.MaKhoiLop);
            builder.HasOne(x => x.LopHoc).WithMany(x => x.HocSinhs).HasForeignKey(x => x.MaLopHoc);

            builder.HasOne(x => x.GioiTinh).WithMany(x => x.HocSinhs).HasForeignKey(x => x.MaGioiTinh);
            builder.HasOne(x => x.DanToc).WithMany(x => x.HocSinhs).HasForeignKey(x => x.MaDanToc);
            builder.HasOne(x => x.TonGiao).WithMany(x => x.HocSinhs).HasForeignKey(x => x.MaTonGiao);
            builder.HasOne(x => x.QuocTich).WithMany(x => x.HocSinhs).HasForeignKey(x => x.MaQuocTich);
            builder.HasOne(x => x.TrangThaiHoc).WithMany(x => x.HocSinhs).HasForeignKey(x => x.MaTrangThaiHoc);
            builder.HasOne(x => x.TrangThaiTaiKhoan).WithMany(x => x.HocSinhs).HasForeignKey(x => x.MaTrangThaiTaiKhoan);
        }
    }
}