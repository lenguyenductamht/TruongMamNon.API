using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class ChiTietPhieuNhapThucPhamConfiguration : IEntityTypeConfiguration<ChiTietPhieuNhapThucPham>
    {
        public void Configure(EntityTypeBuilder<ChiTietPhieuNhapThucPham> builder)
        {
            builder.ToTable("ChiTietPhieuNhapThucPhams");
            builder.HasKey(x => new { x.MaPhieuNhapThucPham, x.MaThucPham });
            builder.Property(x => x.DonGia).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(x => x.SoLuong).IsRequired();

            builder.HasOne(x => x.ThucPham).WithMany(x => x.ChiTietPhieuNhapThucPhams).HasForeignKey(x => x.MaThucPham);
            builder.HasOne(x => x.PhieuNhapThucPham).WithMany(x => x.ChiTietPhieuNhapThucPhams).HasForeignKey(x => x.MaPhieuNhapThucPham);
        }
    }
}