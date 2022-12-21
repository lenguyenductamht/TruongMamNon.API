using TruongMamNon.BackendApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class GiaoVienChuNhiemConfiguration : IEntityTypeConfiguration<GiaoVienChuNhiem>
    {
        public void Configure(EntityTypeBuilder<GiaoVienChuNhiem> builder)
        {
            builder.ToTable("GiaoVienChuNhiems");
            builder.HasKey(x => new { x.MaNhanSu, x.MaLopHoc });

            builder.HasOne(x => x.NhanSu).WithMany(x => x.GiaoVienChuNhiems).HasForeignKey(x => x.MaNhanSu).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.LopHoc).WithMany(x => x.GiaoVienChuNhiems).HasForeignKey(x => x.MaLopHoc);
        }
    }
}