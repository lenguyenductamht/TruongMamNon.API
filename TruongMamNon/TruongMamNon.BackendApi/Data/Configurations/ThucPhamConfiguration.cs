using TruongMamNon.BackendApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

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
            builder.Property(x => x.HinhAnh).IsRequired(false);
            builder.Property(x => x.MaDanhMuc).IsRequired();

            builder.Property(x => x.NangLuong).IsRequired();
            builder.Property(x => x.ChatDam).IsRequired();
            builder.Property(x => x.ChatBeo).IsRequired();
            builder.Property(x => x.ChatBot).IsRequired();

            builder.HasOne(x => x.DanhMucThucPham).WithMany(x => x.ThucPhams).HasForeignKey(x => x.MaDanhMuc);
        }
    }
}