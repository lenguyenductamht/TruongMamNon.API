using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class QuocGiaConfiguration : IEntityTypeConfiguration<QuocGia>
    {
        public void Configure(EntityTypeBuilder<QuocGia> builder)
        {
            builder.ToTable("QuocGias");
            builder.HasKey(x => x.MaQuocGia);
            builder.Property(x => x.MaQuocGia).IsRequired().HasMaxLength(3);
            builder.Property(x => x.TenQuocGia).IsRequired().HasMaxLength(50);
        }
    }
}