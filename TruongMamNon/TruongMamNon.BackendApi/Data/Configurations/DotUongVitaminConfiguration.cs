using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class DotUongVitaminConfiguration : IEntityTypeConfiguration<DotUongVitamin>
    {
        public void Configure(EntityTypeBuilder<DotUongVitamin> builder)
        {
            builder.ToTable("DotUongVitamins");
            builder.HasKey(x => x.MaDotUongVitamin);
            builder.Property(x => x.NgayUongVitamin).IsRequired();
            builder.Property(x => x.MaVitamin).IsRequired();
            builder.Property(x => x.MaNienHoc).IsRequired();

            builder.HasOne(x => x.Vitamin).WithMany(x => x.DotUongVitamins).HasForeignKey(x => x.MaVitamin);
            builder.HasOne(x => x.NienHoc).WithMany(x => x.DotUongVitamins).HasForeignKey(x => x.MaNienHoc);
        }
    }
}