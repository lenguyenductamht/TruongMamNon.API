using TruongMamNon.BackendApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class KhoiLopConfiguration : IEntityTypeConfiguration<KhoiLop>
    {
        public void Configure(EntityTypeBuilder<KhoiLop> builder)
        {
            builder.ToTable("KhoiLops");
            builder.HasKey(x => x.MaKhoiLop);
            builder.Property(x => x.TenKhoiLop).IsRequired().HasMaxLength(200);
            builder.Property(x => x.GhiChu).IsRequired(false);
        }
    }
}