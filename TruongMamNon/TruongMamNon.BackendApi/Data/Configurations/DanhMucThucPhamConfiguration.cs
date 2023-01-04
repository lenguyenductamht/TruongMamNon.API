using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class DanhMucThucPhamConfiguration : IEntityTypeConfiguration<DanhMucThucPham>
    {
        public void Configure(EntityTypeBuilder<DanhMucThucPham> builder)
        {
            builder.ToTable("DanhMucThucPhams");
            builder.HasKey(x => x.MaDanhMuc);
            builder.Property(x => x.TenDanhMuc).IsRequired().HasMaxLength(200);
            builder.Property(x => x.GhiChu).IsRequired(false);
        }
    }
}