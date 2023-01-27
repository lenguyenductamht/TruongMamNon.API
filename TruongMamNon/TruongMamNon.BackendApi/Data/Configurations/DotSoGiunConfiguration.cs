using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class DotSoGiunConfiguration : IEntityTypeConfiguration<DotSoGiun>
    {
        public void Configure(EntityTypeBuilder<DotSoGiun> builder)
        {
            builder.ToTable("DotSoGiuns");
            builder.HasKey(x => x.MaDotSoGiun);
            builder.Property(x => x.TenDotSoGiun).IsRequired().HasMaxLength(200);
            builder.Property(x => x.NgaySoGiun).IsRequired();
            builder.Property(x => x.MaThuocSoGiun).IsRequired();
            builder.Property(x => x.MaNienHoc).IsRequired();

            builder.HasOne(x => x.ThuocSoGiun).WithMany(x => x.DotSoGiuns).HasForeignKey(x => x.MaThuocSoGiun);
            builder.HasOne(x => x.NienHoc).WithMany(x => x.DotSoGiuns).HasForeignKey(x => x.MaNienHoc);
        }
    }
}