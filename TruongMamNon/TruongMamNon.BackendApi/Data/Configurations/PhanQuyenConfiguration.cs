using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class PhanQuyenConfiguration : IEntityTypeConfiguration<PhanQuyen>
    {
        public void Configure(EntityTypeBuilder<PhanQuyen> builder)
        {
            builder.ToTable("PhanQuyens");
            builder.HasKey(x => x.MaQuyen);
            builder.Property(x => x.TenQuyen).IsRequired().HasMaxLength(200);
            builder.Property(x => x.GhiChu).IsRequired(false);
        }
    }
}