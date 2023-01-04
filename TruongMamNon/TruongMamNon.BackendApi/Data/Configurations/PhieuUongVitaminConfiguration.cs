using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class PhieuUongVitaminConfiguration : IEntityTypeConfiguration<PhieuUongVitamin>
    {
        public void Configure(EntityTypeBuilder<PhieuUongVitamin> builder)
        {
            builder.ToTable("PhieuUongVitamins");
            builder.HasKey(x => x.MaPhieuUongVitamin);
            builder.Property(x => x.MaDotUongVitamin).IsRequired();
            builder.Property(x => x.MaHocSinh).IsRequired();
            builder.Property(x => x.TrangThai).IsRequired(false);

            builder.HasOne(x => x.DotUongVitamin).WithMany(x => x.PhieuUongVitamins).HasForeignKey(x => x.MaDotUongVitamin);
            builder.HasOne(x => x.HocSinh).WithMany(x => x.PhieuUongVitamins).HasForeignKey(x => x.MaHocSinh);
        }
    }
}