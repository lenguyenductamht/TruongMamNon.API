using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class LopHocConfiguration : IEntityTypeConfiguration<LopHoc>
    {
        public void Configure(EntityTypeBuilder<LopHoc> builder)
        {
            builder.ToTable("LopHocs");
            builder.HasKey(x => x.MaLop);
            builder.Property(x => x.TenLop).IsRequired().HasMaxLength(200);
            builder.Property(x => x.MaKhoiLop).IsRequired();
            builder.Property(x => x.HocPhi).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(x => x.MaNienHoc).IsRequired();

            builder.HasOne(x => x.KhoiLop).WithMany(x => x.LopHocs).HasForeignKey(x => x.MaKhoiLop);
            builder.HasOne(x => x.NienHoc).WithMany(x => x.LopHocs).HasForeignKey(x => x.MaNienHoc);
        }
    }
}