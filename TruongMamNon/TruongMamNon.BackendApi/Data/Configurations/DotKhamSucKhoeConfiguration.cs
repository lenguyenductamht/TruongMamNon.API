using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class DotKhamSucKhoeConfiguration : IEntityTypeConfiguration<DotKhamSucKhoe>
    {
        public void Configure(EntityTypeBuilder<DotKhamSucKhoe> builder)
        {
            builder.ToTable("DotKhamSucKhoes");
            builder.HasKey(x => x.MaDotKhamSucKhoe);
            builder.Property(x => x.TenDotKhamSucKhoe).IsRequired().HasMaxLength(200);
            builder.Property(x => x.NgayKhamSucKhoe).IsRequired();
            builder.Property(x => x.MaNienHoc).IsRequired();

            builder.HasOne(x => x.NienHoc).WithMany(x => x.DotKhamSucKhoes).HasForeignKey(x => x.MaNienHoc);
        }
    }
}