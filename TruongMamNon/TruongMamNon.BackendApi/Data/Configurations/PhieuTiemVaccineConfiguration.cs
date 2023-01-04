using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class PhieuTiemVaccineConfiguration : IEntityTypeConfiguration<PhieuTiemVaccine>
    {
        public void Configure(EntityTypeBuilder<PhieuTiemVaccine> builder)
        {
            builder.ToTable("PhieuTiemVaccines");
            builder.HasKey(x => x.MaPhieuTiemVaccine);
            builder.Property(x => x.MaDotTiemVaccine).IsRequired();
            builder.Property(x => x.MaHocSinh).IsRequired();
            builder.Property(x => x.TrangThai).IsRequired(false);

            builder.HasOne(x => x.DotTiemVaccine).WithMany(x => x.PhieuTiemVaccines).HasForeignKey(x => x.MaDotTiemVaccine);
            builder.HasOne(x => x.HocSinh).WithMany(x => x.PhieuTiemVaccines).HasForeignKey(x => x.MaHocSinh);
        }
    }
}