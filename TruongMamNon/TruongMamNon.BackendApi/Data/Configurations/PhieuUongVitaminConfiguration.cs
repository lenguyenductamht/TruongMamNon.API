using TruongMamNon.BackendApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class PhieuUongVitaminConfiguration : IEntityTypeConfiguration<PhieuUongVitamin>
    {
        public void Configure(EntityTypeBuilder<PhieuUongVitamin> builder)
        {
            builder.ToTable("PhieuUongVitamins");
            builder.HasKey(x => new { x.MaVitamin, x.NgayUong, x.MaHocSinh });

            builder.HasOne(x => x.Vitamin).WithMany(x => x.PhieuUongVitamins).HasForeignKey(x => x.MaVitamin);
            builder.HasOne(x => x.HocSinh).WithMany(x => x.PhieuUongVitamins).HasForeignKey(x => x.MaHocSinh);
        }
    }
}