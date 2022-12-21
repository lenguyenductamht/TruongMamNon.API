using TruongMamNon.BackendApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class DanhMucThucPhamConfiguration : IEntityTypeConfiguration<DanhMucThucPham>
    {
        public void Configure(EntityTypeBuilder<DanhMucThucPham> builder)
        {
            builder.ToTable("DanhMucThucPhams");
            builder.HasKey(x => x.MaDanhMuc);
            builder.Property(x => x.TenDanhMuc).IsRequired().HasMaxLength(200);
            builder.Property(x => x.GhiChu).IsRequired(false);
        }
    }
}