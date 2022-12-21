using TruongMamNon.BackendApi.Data.Configurations;
using TruongMamNon.BackendApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TruongMamNon.BackendApi.Data.Extensions;

namespace TruongMamNon.BackendApi.Data.EF
{
    public class TruongMamNonDbContext : DbContext
    {
        public TruongMamNonDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ChiTietPhieuNhapThucPhamConfiguration());
            modelBuilder.ApplyConfiguration(new ChiTietPhieuXuatThucPhamConfiguration());
            modelBuilder.ApplyConfiguration(new ChucVuConfiguration());
            modelBuilder.ApplyConfiguration(new DanhMucThucDonConfiguration());
            modelBuilder.ApplyConfiguration(new DanhMucThucPhamConfiguration());
            modelBuilder.ApplyConfiguration(new PhieuNhapThucPhamConfiguration());
            modelBuilder.ApplyConfiguration(new DiemDanhConfiguration());
            modelBuilder.ApplyConfiguration(new GiaoVienChuNhiemConfiguration());
            modelBuilder.ApplyConfiguration(new HocSinhConfiguration());
            modelBuilder.ApplyConfiguration(new KhamSucKhoeConfiguration());
            modelBuilder.ApplyConfiguration(new KhoiLopConfiguration());
            modelBuilder.ApplyConfiguration(new LoaiNhanSuConfiguration());
            modelBuilder.ApplyConfiguration(new LopHocConfiguration());
            modelBuilder.ApplyConfiguration(new MonAnConfiguration());
            modelBuilder.ApplyConfiguration(new MonAnThucPhamConfiguration());
            modelBuilder.ApplyConfiguration(new NienHocConfiguration());
            modelBuilder.ApplyConfiguration(new NhanSuConfiguration());
            modelBuilder.ApplyConfiguration(new NhanSuPhanQuyenConfiguration());
            modelBuilder.ApplyConfiguration(new PhanQuyenConfiguration());
            modelBuilder.ApplyConfiguration(new PhongBanConfiguration());
            modelBuilder.ApplyConfiguration(new PhieuSoGiunConfiguration());
            modelBuilder.ApplyConfiguration(new PhieuTiemVaccineConfiguration());
            modelBuilder.ApplyConfiguration(new ThucDonConfiguration());
            modelBuilder.ApplyConfiguration(new ThucDonMonAnConfiguration());
            modelBuilder.ApplyConfiguration(new ThucPhamConfiguration());
            modelBuilder.ApplyConfiguration(new PhieuUongVitaminConfiguration());
            modelBuilder.ApplyConfiguration(new ThuocSoGiunConfiguration());
            modelBuilder.ApplyConfiguration(new VaccineConfiguration());
            modelBuilder.ApplyConfiguration(new VitaminConfiguration());
            modelBuilder.ApplyConfiguration(new PhieuXuatThucPhamConfiguration());

            //Seed Data
            modelBuilder.Seed();
        }

        #region DbSet

        public DbSet<ChiTietPhieuNhapThucPham> ChiTietDiChos { get; set; }
        public DbSet<ChucVu> ChucVus { get; set; }
        public DbSet<DanhMucThucDon> DanhMucThucDons { get; set; }
        public DbSet<DanhMucThucPham> DanhMucThucPhams { get; set; }
        public DbSet<PhieuNhapThucPham> DiChos { get; set; }
        public DbSet<DiemDanh> DiemDanhs { get; set; }
        public DbSet<GiaoVienChuNhiem> GiaoVienChuNhiems { get; set; }
        public DbSet<HocSinh> HocSinhs { get; set; }
        public DbSet<KhamSucKhoe> KhamSucKhoes { get; set; }
        public DbSet<KhoiLop> KhoiLops { get; set; }
        public DbSet<LoaiNhanSu> LoaiNhanSus { get; set; }
        public DbSet<LopHoc> LopHocs { get; set; }
        public DbSet<MonAn> MonAns { get; set; }
        public DbSet<MonAnThucPham> MonAnThucPhams { get; set; }
        public DbSet<NienHoc> NienHocs { get; set; }
        public DbSet<NhanSu> NhanSus { get; set; }
        public DbSet<NhanSuPhanQuyen> NhanSuPhanQuyens { get; set; }
        public DbSet<PhanQuyen> PhanQuyens { get; set; }
        public DbSet<PhongBan> PhongBans { get; set; }
        public DbSet<PhieuSoGiun> PhieuSoGiuns { get; set; }
        public DbSet<PhieuTiemVaccine> PhieuTiemVaccines { get; set; }
        public DbSet<ThucDon> ThucDons { get; set; }
        public DbSet<ThucDonMonAn> ThucDonMonAns { get; set; }
        public DbSet<ThucPham> ThucPhams { get; set; }
        public DbSet<PhieuUongVitamin> PhieuUongVitamins { get; set; }
        public DbSet<Vaccine> Vaccines { get; set; }
        public DbSet<ThuocSoGiun> ThuocSoGiuns { get; set; }
        public DbSet<Vitamin> Vitamins { get; set; }

        #endregion DbSet
    }
}