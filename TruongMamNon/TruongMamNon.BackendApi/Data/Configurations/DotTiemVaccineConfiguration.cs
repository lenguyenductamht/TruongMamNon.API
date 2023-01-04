using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class DotTiemVaccineConfiguration : IEntityTypeConfiguration<DotTiemVaccine>
    {
        public void Configure(EntityTypeBuilder<DotTiemVaccine> builder)
        {
            builder.ToTable("DotTiemVaccines");
            builder.HasKey(x => x.MaDotTiemVaccine);
            builder.Property(x => x.NgayTiemVaccine).IsRequired();
            builder.Property(x => x.MaVaccine).IsRequired();
            builder.Property(x => x.MaNienHoc).IsRequired();

            builder.HasOne(x => x.Vaccine).WithMany(x => x.DotTiemVaccines).HasForeignKey(x => x.MaVaccine);
            builder.HasOne(x => x.NienHoc).WithMany(x => x.DotTiemVaccines).HasForeignKey(x => x.MaNienHoc);
        }
    }
}