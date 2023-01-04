using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class ThuocSoGiunConfiguration : IEntityTypeConfiguration<ThuocSoGiun>
    {
        public void Configure(EntityTypeBuilder<ThuocSoGiun> builder)
        {
            builder.ToTable("ThuocSoGiuns");
            builder.HasKey(x => x.MaThuocSoGiun);
            builder.Property(x => x.TenThuocSoGiun).IsRequired().HasMaxLength(200);
            builder.Property(x => x.GhiChu).IsRequired(false);
        }
    }
}