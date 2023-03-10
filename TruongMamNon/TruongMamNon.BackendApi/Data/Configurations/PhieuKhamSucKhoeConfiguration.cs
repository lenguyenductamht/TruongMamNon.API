using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class PhieuKhamSucKhoeConfiguration : IEntityTypeConfiguration<PhieuKhamSucKhoe>
    {
        public void Configure(EntityTypeBuilder<PhieuKhamSucKhoe> builder)
        {
            builder.ToTable("PhieuKhamSucKhoes");
            builder.HasKey(x => x.MaPhieuKhamSucKhoe);
            builder.Property(x => x.MaDotKhamSucKhoe).IsRequired();
            builder.Property(x => x.MaHocSinh).IsRequired();
            builder.Property(x => x.KetLuan).IsRequired();

            builder.Property(x => x.ChieuCao).IsRequired();
            builder.Property(x => x.CanNang).IsRequired();
            builder.Property(x => x.BMI).IsRequired();
            builder.Property(x => x.NhipTim).IsRequired();
            builder.Property(x => x.TamThu).IsRequired();
            builder.Property(x => x.TamTruong).IsRequired();
            builder.Property(x => x.LoaiTheLuc).IsRequired();

            builder.Property(x => x.TuanHoan).IsRequired();
            builder.Property(x => x.HoHap).IsRequired();
            builder.Property(x => x.TieuHoa).IsRequired();
            builder.Property(x => x.ThanTietNieu).IsRequired();
            builder.Property(x => x.ThanKinhTamThan).IsRequired();
            builder.Property(x => x.LamSangKhac).IsRequired();

            builder.Property(x => x.MatPhaiKhongKinh).IsRequired();
            builder.Property(x => x.MatTraiKhongKinh).IsRequired();
            builder.Property(x => x.MatPhaiCoKinh).IsRequired();
            builder.Property(x => x.MatTraiCoKinh).IsRequired();
            builder.Property(x => x.CacBenhVeMat).IsRequired();

            builder.Property(x => x.TaiTraiNoiThuong).IsRequired();
            builder.Property(x => x.TaiTraiNoiTham).IsRequired();
            builder.Property(x => x.TaiPhaiNoiThuong).IsRequired();
            builder.Property(x => x.TaiPhaiNoiTham).IsRequired();
            builder.Property(x => x.CacBenhTaiMuiHong).IsRequired();

            builder.Property(x => x.HamTren).IsRequired();
            builder.Property(x => x.HamDuoi).IsRequired();
            builder.Property(x => x.CacBenhRangHamMat).IsRequired();

            builder.HasOne(x => x.DotKhamSucKhoe).WithMany(x => x.PhieuKhamSucKhoes).HasForeignKey(x => x.MaDotKhamSucKhoe);
            builder.HasOne(x => x.HocSinh).WithMany(x => x.PhieuKhamSucKhoes).HasForeignKey(x => x.MaHocSinh);
        }
    }
}