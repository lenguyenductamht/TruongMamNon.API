using TruongMamNon.BackendApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class DiemDanhConfiguration : IEntityTypeConfiguration<DiemDanh>
    {
        public void Configure(EntityTypeBuilder<DiemDanh> builder)
        {
            builder.ToTable("DiemDanhs");
            builder.HasKey(x => x.MaDiemDanh);
            builder.Property(x => x.NgayDiemDanh).IsRequired();
            builder.Property(x => x.MaHocSinh).IsRequired();
            builder.Property(x => x.TrangThai).IsRequired();

            builder.HasOne(x => x.HocSinh).WithMany(x => x.DiemDanhs).HasForeignKey(x => x.MaHocSinh);
        }
    }
}