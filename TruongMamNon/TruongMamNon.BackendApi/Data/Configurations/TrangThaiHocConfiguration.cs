using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class TrangThaiHocConfiguration : IEntityTypeConfiguration<TrangThaiHoc>
    {
        public void Configure(EntityTypeBuilder<TrangThaiHoc> builder)
        {
            builder.ToTable("TrangThaiHocs");
            builder.HasKey(x => x.MaTrangThai);
            builder.Property(x => x.MaTrangThai).IsRequired().HasMaxLength(1);
            builder.Property(x => x.TenTrangThai).IsRequired().HasMaxLength(50);
        }
    }
}