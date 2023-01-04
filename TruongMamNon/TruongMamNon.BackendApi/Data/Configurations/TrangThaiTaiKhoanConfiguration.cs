using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class TrangThaiTaiKhoanConfiguration : IEntityTypeConfiguration<TrangThaiTaiKhoan>
    {
        public void Configure(EntityTypeBuilder<TrangThaiTaiKhoan> builder)
        {
            builder.ToTable("TrangThaiTaiKhoans");
            builder.HasKey(x => x.MaTrangThai);
            builder.Property(x => x.MaTrangThai).IsRequired().HasMaxLength(1);
            builder.Property(x => x.TenTrangThai).IsRequired().HasMaxLength(50);
        }
    }
}