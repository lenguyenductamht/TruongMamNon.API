using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class NienHocConfiguration : IEntityTypeConfiguration<NienHoc>
    {
        public void Configure(EntityTypeBuilder<NienHoc> builder)
        {
            builder.ToTable("NienHocs");
            builder.HasKey(x => x.MaNienHoc);
            builder.Property(x => x.TenNienHoc).IsRequired().HasMaxLength(200);
            builder.Property(x => x.BatDauHK1).IsRequired();
            builder.Property(x => x.KetThucHK1).IsRequired();
            builder.Property(x => x.BatDauHK2).IsRequired();
            builder.Property(x => x.KetThucHK2).IsRequired();
        }
    }
}