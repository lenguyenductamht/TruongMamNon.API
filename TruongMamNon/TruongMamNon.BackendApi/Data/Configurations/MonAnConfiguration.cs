using TruongMamNon.BackendApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class MonAnConfiguration : IEntityTypeConfiguration<MonAn>
    {
        public void Configure(EntityTypeBuilder<MonAn> builder)
        {
            builder.ToTable("MonAns");
            builder.HasKey(x => x.MaMonAn);
            builder.Property(x => x.TenMonAn).IsRequired().HasMaxLength(200);
            builder.Property(x => x.GhiChu).IsRequired(false);
        }
    }
}