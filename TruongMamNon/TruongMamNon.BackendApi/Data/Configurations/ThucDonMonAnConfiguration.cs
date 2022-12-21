using TruongMamNon.BackendApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class ThucDonMonAnConfiguration : IEntityTypeConfiguration<ThucDonMonAn>
    {
        public void Configure(EntityTypeBuilder<ThucDonMonAn> builder)
        {
            builder.ToTable("ThucDonMonAns");
            builder.HasKey(x => new { x.MaThucDon, x.MaMonAn });
            builder.Property(x => x.SoLuong).IsRequired();

            builder.HasOne(x => x.ThucDon).WithMany(x => x.ThucDonMonAns).HasForeignKey(x => x.MaThucDon);
            builder.HasOne(x => x.MonAn).WithMany(x => x.ThucDonMonAns).HasForeignKey(x => x.MaMonAn);
        }
    }
}