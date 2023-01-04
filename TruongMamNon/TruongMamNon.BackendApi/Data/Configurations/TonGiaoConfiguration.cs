using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class TonGiaoConfiguration : IEntityTypeConfiguration<TonGiao>
    {
        public void Configure(EntityTypeBuilder<TonGiao> builder)
        {
            builder.ToTable("TonGiaos");
            builder.HasKey(x => x.MaTonGiao);
            builder.Property(x => x.MaTonGiao).IsRequired().HasMaxLength(3);
            builder.Property(x => x.TenTonGiao).IsRequired().HasMaxLength(50);
        }
    }
}