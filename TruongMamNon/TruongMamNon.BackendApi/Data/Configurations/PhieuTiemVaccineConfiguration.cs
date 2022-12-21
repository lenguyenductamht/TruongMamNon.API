using TruongMamNon.BackendApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class PhieuTiemVaccineConfiguration : IEntityTypeConfiguration<PhieuTiemVaccine>
    {
        public void Configure(EntityTypeBuilder<PhieuTiemVaccine> builder)
        {
            builder.ToTable("PhieuTiemVaccines");
            builder.HasKey(x => new { x.MaVaccine, x.NgayTiem, x.MaHocSinh });

            builder.HasOne(x => x.Vaccine).WithMany(x => x.PhieuTiemVaccines).HasForeignKey(x => x.MaVaccine);
            builder.HasOne(x => x.HocSinh).WithMany(x => x.PhieuTiemVaccines).HasForeignKey(x => x.MaHocSinh);
        }
    }
}