using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class MonAnThucPhamConfiguration : IEntityTypeConfiguration<MonAnThucPham>
    {
        public void Configure(EntityTypeBuilder<MonAnThucPham> builder)
        {
            builder.ToTable("MonAnThucPhams");
            builder.HasKey(x => new { x.MaMonAn, x.MaThucPham });
            builder.Property(x => x.SoLuong).IsRequired();

            builder.HasOne(x => x.MonAn).WithMany(x => x.MonAnThucPhams).HasForeignKey(x => x.MaMonAn);
            builder.HasOne(x => x.ThucPham).WithMany(x => x.MonAnThucPhams).HasForeignKey(x => x.MaThucPham);
        }
    }
}