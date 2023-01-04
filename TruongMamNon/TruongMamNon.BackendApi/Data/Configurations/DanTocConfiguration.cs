using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class DanTocConfiguration : IEntityTypeConfiguration<DanToc>
    {
        public void Configure(EntityTypeBuilder<DanToc> builder)
        {
            builder.ToTable("DanTocs");
            builder.HasKey(x => x.MaDanToc);
            builder.Property(x => x.MaDanToc).IsRequired().HasMaxLength(3);
            builder.Property(x => x.TenDanToc).IsRequired().HasMaxLength(50);
        }
    }
}