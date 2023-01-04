using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class PhieuSoGiunConfiguration : IEntityTypeConfiguration<PhieuSoGiun>
    {
        public void Configure(EntityTypeBuilder<PhieuSoGiun> builder)
        {
            builder.ToTable("PhieuSoGiuns");
            builder.HasKey(x => x.MaPhieuSoGiun);
            builder.Property(x => x.MaDotSoGiun).IsRequired();
            builder.Property(x => x.MaHocSinh).IsRequired();
            builder.Property(x => x.TrangThai).IsRequired(false);

            builder.HasOne(x => x.DotSoGiun).WithMany(x => x.PhieuSoGiuns).HasForeignKey(x => x.MaDotSoGiun);
            builder.HasOne(x => x.HocSinh).WithMany(x => x.PhieuSoGiuns).HasForeignKey(x => x.MaHocSinh);
        }
    }
}