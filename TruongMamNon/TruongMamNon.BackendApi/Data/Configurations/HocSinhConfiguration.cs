using TruongMamNon.BackendApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

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
            builder.Property(x => x.GioiTinh).IsRequired();
            builder.Property(x => x.MaKhoiLop).IsRequired();
            builder.Property(x => x.MaLopHoc).IsRequired(false);
            builder.Property(x => x.NgayNhapHoc).IsRequired();
            builder.Property(x => x.TrangThaiHoc).IsRequired();
            builder.Property(x => x.LyDoNghiHoc).IsRequired(false);
            builder.Property(x => x.NgayCapNhat).IsRequired(false);
            builder.Property(x => x.NgaySinh).IsRequired();
            builder.Property(x => x.NoiSinh).IsRequired(false);
            builder.Property(x => x.DanToc).IsRequired(false);
            builder.Property(x => x.TonGiao).IsRequired(false);
            builder.Property(x => x.QuocTich).IsRequired(false);
            builder.Property(x => x.GhiChu).IsRequired(false);
            builder.Property(x => x.HoKhau).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.DiaChi).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.MatKhau).IsRequired().HasMaxLength(200);
            builder.Property(x => x.TrangThaiTaiKhoan).IsRequired();
            builder.Property(x => x.HinhAnh).IsRequired(false);
            builder.Property(x => x.HoTenPhuHuynh).IsRequired();
            builder.Property(x => x.NamSinhPhuHuynh).IsRequired(false);
            builder.Property(x => x.CMNDPhuHuynh).IsRequired(false);
            builder.Property(x => x.SDTPhuHuynh).IsRequired(false);
            builder.Property(x => x.NgheNghiepPhuHuynh).IsRequired(false);
            builder.Property(x => x.EmailPhuHuynh).IsRequired(false);
            builder.Property(x => x.DiaChiPhuHuynh).IsRequired(false);

            builder.HasOne(x => x.KhoiLop).WithMany(x => x.HocSinhs).HasForeignKey(x => x.MaKhoiLop);
            builder.HasOne(x => x.LopHoc).WithMany(x => x.HocSinhs).HasForeignKey(x => x.MaLopHoc);
        }
    }
}