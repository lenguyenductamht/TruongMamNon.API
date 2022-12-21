using TruongMamNon.BackendApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class PhieuSoGiunConfiguration : IEntityTypeConfiguration<PhieuSoGiun>
    {
        public void Configure(EntityTypeBuilder<PhieuSoGiun> builder)
        {
            builder.ToTable("PhieuSoGiuns");
            builder.HasKey(x => new { x.MaThuocSoGiun, x.NgaySoGiun, x.MaHocSinh });

            builder.HasOne(x => x.ThuocSoGiun).WithMany(x => x.PhieuSoGiuns).HasForeignKey(x => x.MaThuocSoGiun);
            builder.HasOne(x => x.HocSinh).WithMany(x => x.PhieuSoGiuns).HasForeignKey(x => x.MaHocSinh);
        }
    }
}