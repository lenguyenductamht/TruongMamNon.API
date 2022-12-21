using TruongMamNon.BackendApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class NhanSuPhanQuyenConfiguration : IEntityTypeConfiguration<NhanSuPhanQuyen>
    {
        public void Configure(EntityTypeBuilder<NhanSuPhanQuyen> builder)
        {
            builder.ToTable("NhanSuPhanQuyens");
            builder.HasKey(x => new { x.MaNhanSu, x.MaQuyen });

            builder.HasOne(x => x.NhanSu).WithMany(x => x.NhanSuPhanQuyens).HasForeignKey(x => x.MaNhanSu);
            builder.HasOne(x => x.PhanQuyen).WithMany(x => x.NhanSuPhanQuyens).HasForeignKey(x => x.MaQuyen);
        }
    }
}