using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class DanhMucThucDonConfiguration : IEntityTypeConfiguration<DanhMucThucDon>
    {
        public void Configure(EntityTypeBuilder<DanhMucThucDon> builder)
        {
            builder.ToTable("DanhMucThucDons");
            builder.HasKey(x => x.MaDanhMuc);
            builder.Property(x => x.TenDanhMuc).IsRequired().HasMaxLength(200);
            builder.Property(x => x.GhiChu).IsRequired(false);
            builder.Property(x => x.ThoiGian).IsRequired();
            builder.Property(x => x.NangLuong).IsRequired();
            builder.Property(x => x.ChatDam).IsRequired();
            builder.Property(x => x.ChatBeo).IsRequired();
            builder.Property(x => x.ChatBot).IsRequired();
        }
    }
}