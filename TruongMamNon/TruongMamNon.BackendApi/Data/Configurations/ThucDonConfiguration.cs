using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class ThucDonConfiguration : IEntityTypeConfiguration<ThucDon>
    {
        public void Configure(EntityTypeBuilder<ThucDon> builder)
        {
            builder.ToTable("ThucDons");
            builder.HasKey(x => x.MaThucDon);
            builder.Property(x => x.NgayApDung).IsRequired();
            builder.Property(x => x.NgayTao).IsRequired();
            builder.Property(x => x.MaDanhMuc).IsRequired();

            builder.HasOne(x => x.DanhMucThucDon).WithMany(x => x.ThucDons).HasForeignKey(x => x.MaDanhMuc);
        }
    }
}