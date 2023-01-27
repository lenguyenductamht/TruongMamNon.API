using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruongMamNon.BackendApi.Data.Migrations
{
    public partial class TrangThaiDiemDanh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChucVus_LoaiNhanSus_LoaiNhanSuMaLoaiNhanSu",
                table: "ChucVus");

            migrationBuilder.DropForeignKey(
                name: "FK_DiemDanhs_HocSinhs_HocSinhMaHocSinh",
                table: "DiemDanhs");

            migrationBuilder.DropForeignKey(
                name: "FK_DotSoGiuns_NienHocs_NienHocMaNienHoc",
                table: "DotSoGiuns");

            migrationBuilder.DropForeignKey(
                name: "FK_DotSoGiuns_ThuocSoGiuns_ThuocSoGiunMaThuocSoGiun",
                table: "DotSoGiuns");

            migrationBuilder.DropForeignKey(
                name: "FK_DotTiemVaccines_NienHocs_NienHocMaNienHoc",
                table: "DotTiemVaccines");

            migrationBuilder.DropForeignKey(
                name: "FK_DotTiemVaccines_Vaccines_VaccineMaVaccine",
                table: "DotTiemVaccines");

            migrationBuilder.DropForeignKey(
                name: "FK_DotUongVitamins_NienHocs_NienHocMaNienHoc",
                table: "DotUongVitamins");

            migrationBuilder.DropForeignKey(
                name: "FK_DotUongVitamins_Vitamins_VitaminMaVitamin",
                table: "DotUongVitamins");

            migrationBuilder.DropForeignKey(
                name: "FK_GiaoVienChuNhiems_LopHocs_LopHocMaLop",
                table: "GiaoVienChuNhiems");

            migrationBuilder.DropForeignKey(
                name: "FK_GiaoVienChuNhiems_NhanSus_MaNhanSu",
                table: "GiaoVienChuNhiems");

            migrationBuilder.DropForeignKey(
                name: "FK_HocSinhs_DanTocs_DanTocMaDanToc",
                table: "HocSinhs");

            migrationBuilder.DropForeignKey(
                name: "FK_HocSinhs_GioiTinh_GioiTinhMaGioiTinh",
                table: "HocSinhs");

            migrationBuilder.DropForeignKey(
                name: "FK_HocSinhs_KhoiLops_KhoiLopMaKhoiLop",
                table: "HocSinhs");

            migrationBuilder.DropForeignKey(
                name: "FK_HocSinhs_LopHocs_LopHocMaLop",
                table: "HocSinhs");

            migrationBuilder.DropForeignKey(
                name: "FK_HocSinhs_QuocGias_QuocTichMaQuocGia",
                table: "HocSinhs");

            migrationBuilder.DropForeignKey(
                name: "FK_HocSinhs_TonGiaos_TonGiaoMaTonGiao",
                table: "HocSinhs");

            migrationBuilder.DropForeignKey(
                name: "FK_HocSinhs_TrangThaiHocs_TrangThaiHocMaTrangThai",
                table: "HocSinhs");

            migrationBuilder.DropForeignKey(
                name: "FK_HocSinhs_TrangThaiTaiKhoans_TrangThaiTaiKhoanMaTrangThai",
                table: "HocSinhs");

            migrationBuilder.DropForeignKey(
                name: "FK_LopHocs_KhoiLops_KhoiLopMaKhoiLop",
                table: "LopHocs");

            migrationBuilder.DropForeignKey(
                name: "FK_LopHocs_NienHocs_NienHocMaNienHoc",
                table: "LopHocs");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanSus_ChucVus_ChucVuMaChucVu",
                table: "NhanSus");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanSus_DanTocs_DanTocMaDanToc",
                table: "NhanSus");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanSus_GioiTinh_GioiTinhMaGioiTinh",
                table: "NhanSus");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanSus_KhoiLops_KhoiLopMaKhoiLop",
                table: "NhanSus");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanSus_LoaiNhanSus_LoaiNhanSuMaLoaiNhanSu",
                table: "NhanSus");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanSus_PhongBans_PhongBanMaPhongBan",
                table: "NhanSus");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanSus_QuocGias_QuocTichMaQuocGia",
                table: "NhanSus");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanSus_TonGiaos_TonGiaoMaTonGiao",
                table: "NhanSus");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanSus_TrangThaiLamViecs_TrangThaiLamViecMaTrangThai",
                table: "NhanSus");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanSus_TrangThaiTaiKhoans_TrangThaiTaiKhoanMaTrangThai",
                table: "NhanSus");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuNhapThucPhams_NhanSus_NguoiNhapMaNhanSu",
                table: "PhieuNhapThucPhams");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuSoGiuns_DotSoGiuns_DotSoGiunMaDotSoGiun",
                table: "PhieuSoGiuns");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuSoGiuns_HocSinhs_HocSinhMaHocSinh",
                table: "PhieuSoGiuns");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuTiemVaccines_DotTiemVaccines_DotTiemVaccineMaDotTiemVaccine",
                table: "PhieuTiemVaccines");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuTiemVaccines_HocSinhs_HocSinhMaHocSinh",
                table: "PhieuTiemVaccines");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuUongVitamins_DotUongVitamins_DotUongVitaminMaDotUongVitamin",
                table: "PhieuUongVitamins");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuUongVitamins_HocSinhs_HocSinhMaHocSinh",
                table: "PhieuUongVitamins");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuXuatThucPhams_NhanSus_NguoiXuatMaNhanSu",
                table: "PhieuXuatThucPhams");

            migrationBuilder.DropForeignKey(
                name: "FK_ThucDonMonAns_MonAns_MonAnMaMonAn",
                table: "ThucDonMonAns");

            migrationBuilder.DropForeignKey(
                name: "FK_ThucDonMonAns_ThucDons_ThucDonMaThucDon",
                table: "ThucDonMonAns");

            migrationBuilder.DropForeignKey(
                name: "FK_ThucDons_DanhMucThucDons_DanhMucThucDonMaDanhMuc",
                table: "ThucDons");

            migrationBuilder.DropForeignKey(
                name: "FK_ThucPhams_DanhMucThucPhams_DanhMucThucPhamMaDanhMuc",
                table: "ThucPhams");

            migrationBuilder.DropIndex(
                name: "IX_ThucPhams_DanhMucThucPhamMaDanhMuc",
                table: "ThucPhams");

            migrationBuilder.DropIndex(
                name: "IX_ThucDons_DanhMucThucDonMaDanhMuc",
                table: "ThucDons");

            migrationBuilder.DropIndex(
                name: "IX_ThucDonMonAns_MonAnMaMonAn",
                table: "ThucDonMonAns");

            migrationBuilder.DropIndex(
                name: "IX_ThucDonMonAns_ThucDonMaThucDon",
                table: "ThucDonMonAns");

            migrationBuilder.DropIndex(
                name: "IX_PhieuXuatThucPhams_NguoiXuatMaNhanSu",
                table: "PhieuXuatThucPhams");

            migrationBuilder.DropIndex(
                name: "IX_PhieuUongVitamins_DotUongVitaminMaDotUongVitamin",
                table: "PhieuUongVitamins");

            migrationBuilder.DropIndex(
                name: "IX_PhieuUongVitamins_HocSinhMaHocSinh",
                table: "PhieuUongVitamins");

            migrationBuilder.DropIndex(
                name: "IX_PhieuTiemVaccines_DotTiemVaccineMaDotTiemVaccine",
                table: "PhieuTiemVaccines");

            migrationBuilder.DropIndex(
                name: "IX_PhieuTiemVaccines_HocSinhMaHocSinh",
                table: "PhieuTiemVaccines");

            migrationBuilder.DropIndex(
                name: "IX_PhieuSoGiuns_DotSoGiunMaDotSoGiun",
                table: "PhieuSoGiuns");

            migrationBuilder.DropIndex(
                name: "IX_PhieuSoGiuns_HocSinhMaHocSinh",
                table: "PhieuSoGiuns");

            migrationBuilder.DropIndex(
                name: "IX_PhieuNhapThucPhams_NguoiNhapMaNhanSu",
                table: "PhieuNhapThucPhams");

            migrationBuilder.DropIndex(
                name: "IX_NhanSus_ChucVuMaChucVu",
                table: "NhanSus");

            migrationBuilder.DropIndex(
                name: "IX_NhanSus_DanTocMaDanToc",
                table: "NhanSus");

            migrationBuilder.DropIndex(
                name: "IX_NhanSus_GioiTinhMaGioiTinh",
                table: "NhanSus");

            migrationBuilder.DropIndex(
                name: "IX_NhanSus_KhoiLopMaKhoiLop",
                table: "NhanSus");

            migrationBuilder.DropIndex(
                name: "IX_NhanSus_LoaiNhanSuMaLoaiNhanSu",
                table: "NhanSus");

            migrationBuilder.DropIndex(
                name: "IX_NhanSus_PhongBanMaPhongBan",
                table: "NhanSus");

            migrationBuilder.DropIndex(
                name: "IX_NhanSus_QuocTichMaQuocGia",
                table: "NhanSus");

            migrationBuilder.DropIndex(
                name: "IX_NhanSus_TonGiaoMaTonGiao",
                table: "NhanSus");

            migrationBuilder.DropIndex(
                name: "IX_NhanSus_TrangThaiLamViecMaTrangThai",
                table: "NhanSus");

            migrationBuilder.DropIndex(
                name: "IX_NhanSus_TrangThaiTaiKhoanMaTrangThai",
                table: "NhanSus");

            migrationBuilder.DropIndex(
                name: "IX_LopHocs_KhoiLopMaKhoiLop",
                table: "LopHocs");

            migrationBuilder.DropIndex(
                name: "IX_LopHocs_NienHocMaNienHoc",
                table: "LopHocs");

            migrationBuilder.DropIndex(
                name: "IX_HocSinhs_DanTocMaDanToc",
                table: "HocSinhs");

            migrationBuilder.DropIndex(
                name: "IX_HocSinhs_GioiTinhMaGioiTinh",
                table: "HocSinhs");

            migrationBuilder.DropIndex(
                name: "IX_HocSinhs_KhoiLopMaKhoiLop",
                table: "HocSinhs");

            migrationBuilder.DropIndex(
                name: "IX_HocSinhs_LopHocMaLop",
                table: "HocSinhs");

            migrationBuilder.DropIndex(
                name: "IX_HocSinhs_QuocTichMaQuocGia",
                table: "HocSinhs");

            migrationBuilder.DropIndex(
                name: "IX_HocSinhs_TonGiaoMaTonGiao",
                table: "HocSinhs");

            migrationBuilder.DropIndex(
                name: "IX_HocSinhs_TrangThaiHocMaTrangThai",
                table: "HocSinhs");

            migrationBuilder.DropIndex(
                name: "IX_HocSinhs_TrangThaiTaiKhoanMaTrangThai",
                table: "HocSinhs");

            migrationBuilder.DropIndex(
                name: "IX_GiaoVienChuNhiems_LopHocMaLop",
                table: "GiaoVienChuNhiems");

            migrationBuilder.DropIndex(
                name: "IX_DotUongVitamins_NienHocMaNienHoc",
                table: "DotUongVitamins");

            migrationBuilder.DropIndex(
                name: "IX_DotUongVitamins_VitaminMaVitamin",
                table: "DotUongVitamins");

            migrationBuilder.DropIndex(
                name: "IX_DotTiemVaccines_NienHocMaNienHoc",
                table: "DotTiemVaccines");

            migrationBuilder.DropIndex(
                name: "IX_DotTiemVaccines_VaccineMaVaccine",
                table: "DotTiemVaccines");

            migrationBuilder.DropIndex(
                name: "IX_DotSoGiuns_NienHocMaNienHoc",
                table: "DotSoGiuns");

            migrationBuilder.DropIndex(
                name: "IX_DotSoGiuns_ThuocSoGiunMaThuocSoGiun",
                table: "DotSoGiuns");

            migrationBuilder.DropIndex(
                name: "IX_DiemDanhs_HocSinhMaHocSinh",
                table: "DiemDanhs");

            migrationBuilder.DropIndex(
                name: "IX_ChucVus_LoaiNhanSuMaLoaiNhanSu",
                table: "ChucVus");

            migrationBuilder.DropColumn(
                name: "DanhMucThucPhamMaDanhMuc",
                table: "ThucPhams");

            migrationBuilder.DropColumn(
                name: "DanhMucThucDonMaDanhMuc",
                table: "ThucDons");

            migrationBuilder.DropColumn(
                name: "MonAnMaMonAn",
                table: "ThucDonMonAns");

            migrationBuilder.DropColumn(
                name: "ThucDonMaThucDon",
                table: "ThucDonMonAns");

            migrationBuilder.DropColumn(
                name: "NguoiXuatMaNhanSu",
                table: "PhieuXuatThucPhams");

            migrationBuilder.DropColumn(
                name: "DotUongVitaminMaDotUongVitamin",
                table: "PhieuUongVitamins");

            migrationBuilder.DropColumn(
                name: "HocSinhMaHocSinh",
                table: "PhieuUongVitamins");

            migrationBuilder.DropColumn(
                name: "DotTiemVaccineMaDotTiemVaccine",
                table: "PhieuTiemVaccines");

            migrationBuilder.DropColumn(
                name: "HocSinhMaHocSinh",
                table: "PhieuTiemVaccines");

            migrationBuilder.DropColumn(
                name: "DotSoGiunMaDotSoGiun",
                table: "PhieuSoGiuns");

            migrationBuilder.DropColumn(
                name: "HocSinhMaHocSinh",
                table: "PhieuSoGiuns");

            migrationBuilder.DropColumn(
                name: "NguoiNhapMaNhanSu",
                table: "PhieuNhapThucPhams");

            migrationBuilder.DropColumn(
                name: "ChucVuMaChucVu",
                table: "NhanSus");

            migrationBuilder.DropColumn(
                name: "DanTocMaDanToc",
                table: "NhanSus");

            migrationBuilder.DropColumn(
                name: "GioiTinhMaGioiTinh",
                table: "NhanSus");

            migrationBuilder.DropColumn(
                name: "KhoiLopMaKhoiLop",
                table: "NhanSus");

            migrationBuilder.DropColumn(
                name: "LoaiNhanSuMaLoaiNhanSu",
                table: "NhanSus");

            migrationBuilder.DropColumn(
                name: "PhongBanMaPhongBan",
                table: "NhanSus");

            migrationBuilder.DropColumn(
                name: "QuocTichMaQuocGia",
                table: "NhanSus");

            migrationBuilder.DropColumn(
                name: "TonGiaoMaTonGiao",
                table: "NhanSus");

            migrationBuilder.DropColumn(
                name: "TrangThaiLamViecMaTrangThai",
                table: "NhanSus");

            migrationBuilder.DropColumn(
                name: "TrangThaiTaiKhoanMaTrangThai",
                table: "NhanSus");

            migrationBuilder.DropColumn(
                name: "KhoiLopMaKhoiLop",
                table: "LopHocs");

            migrationBuilder.DropColumn(
                name: "NienHocMaNienHoc",
                table: "LopHocs");

            migrationBuilder.DropColumn(
                name: "DanTocMaDanToc",
                table: "HocSinhs");

            migrationBuilder.DropColumn(
                name: "GioiTinhMaGioiTinh",
                table: "HocSinhs");

            migrationBuilder.DropColumn(
                name: "KhoiLopMaKhoiLop",
                table: "HocSinhs");

            migrationBuilder.DropColumn(
                name: "LopHocMaLop",
                table: "HocSinhs");

            migrationBuilder.DropColumn(
                name: "QuocTichMaQuocGia",
                table: "HocSinhs");

            migrationBuilder.DropColumn(
                name: "TonGiaoMaTonGiao",
                table: "HocSinhs");

            migrationBuilder.DropColumn(
                name: "TrangThaiHocMaTrangThai",
                table: "HocSinhs");

            migrationBuilder.DropColumn(
                name: "TrangThaiTaiKhoanMaTrangThai",
                table: "HocSinhs");

            migrationBuilder.DropColumn(
                name: "LopHocMaLop",
                table: "GiaoVienChuNhiems");

            migrationBuilder.DropColumn(
                name: "NienHocMaNienHoc",
                table: "DotUongVitamins");

            migrationBuilder.DropColumn(
                name: "VitaminMaVitamin",
                table: "DotUongVitamins");

            migrationBuilder.DropColumn(
                name: "NienHocMaNienHoc",
                table: "DotTiemVaccines");

            migrationBuilder.DropColumn(
                name: "VaccineMaVaccine",
                table: "DotTiemVaccines");

            migrationBuilder.DropColumn(
                name: "NienHocMaNienHoc",
                table: "DotSoGiuns");

            migrationBuilder.DropColumn(
                name: "ThuocSoGiunMaThuocSoGiun",
                table: "DotSoGiuns");

            migrationBuilder.DropColumn(
                name: "HocSinhMaHocSinh",
                table: "DiemDanhs");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "DiemDanhs");

            migrationBuilder.DropColumn(
                name: "LoaiNhanSuMaLoaiNhanSu",
                table: "ChucVus");

            migrationBuilder.AlterColumn<string>(
                name: "MaNguoiXuat",
                table: "PhieuXuatThucPhams",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MaHocSinh",
                table: "PhieuUongVitamins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MaHocSinh",
                table: "PhieuTiemVaccines",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MaHocSinh",
                table: "PhieuSoGiuns",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MaNguoiNhap",
                table: "PhieuNhapThucPhams",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MaTrangThaiTaiKhoan",
                table: "NhanSus",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MaTrangThaiLamViec",
                table: "NhanSus",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MaHocSinh",
                table: "DiemDanhs",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "MaTrangThaiDiemDanh",
                table: "DiemDanhs",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "PhieuXuatThucPhamMaPhieuXuatThucPham",
                table: "ChiTietPhieuNhapThucPhams",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TrangThaiDiemDanhs",
                columns: table => new
                {
                    MaTrangThai = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    TenTrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrangThaiDiemDanhs", x => x.MaTrangThai);
                });

            migrationBuilder.UpdateData(
                table: "HocSinhs",
                keyColumn: "MaHocSinh",
                keyValue: "2020210001",
                column: "NgayCapNhat",
                value: new DateTime(2023, 1, 9, 14, 56, 50, 319, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "NhanSus",
                keyColumn: "MaNhanSu",
                keyValue: "1020210001",
                column: "NgayCapNhat",
                value: new DateTime(2023, 1, 9, 14, 56, 50, 319, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.CreateIndex(
                name: "IX_ThucPhams_MaDanhMuc",
                table: "ThucPhams",
                column: "MaDanhMuc");

            migrationBuilder.CreateIndex(
                name: "IX_ThucDons_MaDanhMuc",
                table: "ThucDons",
                column: "MaDanhMuc");

            migrationBuilder.CreateIndex(
                name: "IX_ThucDonMonAns_MaMonAn",
                table: "ThucDonMonAns",
                column: "MaMonAn");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuXuatThucPhams_MaNguoiXuat",
                table: "PhieuXuatThucPhams",
                column: "MaNguoiXuat");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuUongVitamins_MaDotUongVitamin",
                table: "PhieuUongVitamins",
                column: "MaDotUongVitamin");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuUongVitamins_MaHocSinh",
                table: "PhieuUongVitamins",
                column: "MaHocSinh");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuTiemVaccines_MaDotTiemVaccine",
                table: "PhieuTiemVaccines",
                column: "MaDotTiemVaccine");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuTiemVaccines_MaHocSinh",
                table: "PhieuTiemVaccines",
                column: "MaHocSinh");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuSoGiuns_MaDotSoGiun",
                table: "PhieuSoGiuns",
                column: "MaDotSoGiun");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuSoGiuns_MaHocSinh",
                table: "PhieuSoGiuns",
                column: "MaHocSinh");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhapThucPhams_MaNguoiNhap",
                table: "PhieuNhapThucPhams",
                column: "MaNguoiNhap");

            migrationBuilder.CreateIndex(
                name: "IX_NhanSus_MaChucVu",
                table: "NhanSus",
                column: "MaChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_NhanSus_MaDanToc",
                table: "NhanSus",
                column: "MaDanToc");

            migrationBuilder.CreateIndex(
                name: "IX_NhanSus_MaGioiTinh",
                table: "NhanSus",
                column: "MaGioiTinh");

            migrationBuilder.CreateIndex(
                name: "IX_NhanSus_MaKhoiLop",
                table: "NhanSus",
                column: "MaKhoiLop");

            migrationBuilder.CreateIndex(
                name: "IX_NhanSus_MaLoaiNhanSu",
                table: "NhanSus",
                column: "MaLoaiNhanSu");

            migrationBuilder.CreateIndex(
                name: "IX_NhanSus_MaPhongBan",
                table: "NhanSus",
                column: "MaPhongBan");

            migrationBuilder.CreateIndex(
                name: "IX_NhanSus_MaQuocTich",
                table: "NhanSus",
                column: "MaQuocTich");

            migrationBuilder.CreateIndex(
                name: "IX_NhanSus_MaTonGiao",
                table: "NhanSus",
                column: "MaTonGiao");

            migrationBuilder.CreateIndex(
                name: "IX_NhanSus_MaTrangThaiLamViec",
                table: "NhanSus",
                column: "MaTrangThaiLamViec");

            migrationBuilder.CreateIndex(
                name: "IX_NhanSus_MaTrangThaiTaiKhoan",
                table: "NhanSus",
                column: "MaTrangThaiTaiKhoan");

            migrationBuilder.CreateIndex(
                name: "IX_LopHocs_MaKhoiLop",
                table: "LopHocs",
                column: "MaKhoiLop");

            migrationBuilder.CreateIndex(
                name: "IX_LopHocs_MaNienHoc",
                table: "LopHocs",
                column: "MaNienHoc");

            migrationBuilder.CreateIndex(
                name: "IX_HocSinhs_MaDanToc",
                table: "HocSinhs",
                column: "MaDanToc");

            migrationBuilder.CreateIndex(
                name: "IX_HocSinhs_MaGioiTinh",
                table: "HocSinhs",
                column: "MaGioiTinh");

            migrationBuilder.CreateIndex(
                name: "IX_HocSinhs_MaKhoiLop",
                table: "HocSinhs",
                column: "MaKhoiLop");

            migrationBuilder.CreateIndex(
                name: "IX_HocSinhs_MaLopHoc",
                table: "HocSinhs",
                column: "MaLopHoc");

            migrationBuilder.CreateIndex(
                name: "IX_HocSinhs_MaQuocTich",
                table: "HocSinhs",
                column: "MaQuocTich");

            migrationBuilder.CreateIndex(
                name: "IX_HocSinhs_MaTonGiao",
                table: "HocSinhs",
                column: "MaTonGiao");

            migrationBuilder.CreateIndex(
                name: "IX_HocSinhs_MaTrangThaiHoc",
                table: "HocSinhs",
                column: "MaTrangThaiHoc");

            migrationBuilder.CreateIndex(
                name: "IX_HocSinhs_MaTrangThaiTaiKhoan",
                table: "HocSinhs",
                column: "MaTrangThaiTaiKhoan");

            migrationBuilder.CreateIndex(
                name: "IX_GiaoVienChuNhiems_MaLopHoc",
                table: "GiaoVienChuNhiems",
                column: "MaLopHoc");

            migrationBuilder.CreateIndex(
                name: "IX_DotUongVitamins_MaNienHoc",
                table: "DotUongVitamins",
                column: "MaNienHoc");

            migrationBuilder.CreateIndex(
                name: "IX_DotUongVitamins_MaVitamin",
                table: "DotUongVitamins",
                column: "MaVitamin");

            migrationBuilder.CreateIndex(
                name: "IX_DotTiemVaccines_MaNienHoc",
                table: "DotTiemVaccines",
                column: "MaNienHoc");

            migrationBuilder.CreateIndex(
                name: "IX_DotTiemVaccines_MaVaccine",
                table: "DotTiemVaccines",
                column: "MaVaccine");

            migrationBuilder.CreateIndex(
                name: "IX_DotSoGiuns_MaNienHoc",
                table: "DotSoGiuns",
                column: "MaNienHoc");

            migrationBuilder.CreateIndex(
                name: "IX_DotSoGiuns_MaThuocSoGiun",
                table: "DotSoGiuns",
                column: "MaThuocSoGiun");

            migrationBuilder.CreateIndex(
                name: "IX_DiemDanhs_MaHocSinh",
                table: "DiemDanhs",
                column: "MaHocSinh");

            migrationBuilder.CreateIndex(
                name: "IX_DiemDanhs_MaTrangThaiDiemDanh",
                table: "DiemDanhs",
                column: "MaTrangThaiDiemDanh");

            migrationBuilder.CreateIndex(
                name: "IX_ChucVus_MaLoaiNhanSu",
                table: "ChucVus",
                column: "MaLoaiNhanSu");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuNhapThucPhams_PhieuXuatThucPhamMaPhieuXuatThucPham",
                table: "ChiTietPhieuNhapThucPhams",
                column: "PhieuXuatThucPhamMaPhieuXuatThucPham");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietPhieuNhapThucPhams_PhieuXuatThucPhams_PhieuXuatThucPhamMaPhieuXuatThucPham",
                table: "ChiTietPhieuNhapThucPhams",
                column: "PhieuXuatThucPhamMaPhieuXuatThucPham",
                principalTable: "PhieuXuatThucPhams",
                principalColumn: "MaPhieuXuatThucPham");

            migrationBuilder.AddForeignKey(
                name: "FK_ChucVus_LoaiNhanSus_MaLoaiNhanSu",
                table: "ChucVus",
                column: "MaLoaiNhanSu",
                principalTable: "LoaiNhanSus",
                principalColumn: "MaLoaiNhanSu",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DiemDanhs_HocSinhs_MaHocSinh",
                table: "DiemDanhs",
                column: "MaHocSinh",
                principalTable: "HocSinhs",
                principalColumn: "MaHocSinh",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DiemDanhs_TrangThaiDiemDanhs_MaTrangThaiDiemDanh",
                table: "DiemDanhs",
                column: "MaTrangThaiDiemDanh",
                principalTable: "TrangThaiDiemDanhs",
                principalColumn: "MaTrangThai",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DotSoGiuns_NienHocs_MaNienHoc",
                table: "DotSoGiuns",
                column: "MaNienHoc",
                principalTable: "NienHocs",
                principalColumn: "MaNienHoc",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DotSoGiuns_ThuocSoGiuns_MaThuocSoGiun",
                table: "DotSoGiuns",
                column: "MaThuocSoGiun",
                principalTable: "ThuocSoGiuns",
                principalColumn: "MaThuocSoGiun",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DotTiemVaccines_NienHocs_MaNienHoc",
                table: "DotTiemVaccines",
                column: "MaNienHoc",
                principalTable: "NienHocs",
                principalColumn: "MaNienHoc",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DotTiemVaccines_Vaccines_MaVaccine",
                table: "DotTiemVaccines",
                column: "MaVaccine",
                principalTable: "Vaccines",
                principalColumn: "MaVaccine",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DotUongVitamins_NienHocs_MaNienHoc",
                table: "DotUongVitamins",
                column: "MaNienHoc",
                principalTable: "NienHocs",
                principalColumn: "MaNienHoc",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DotUongVitamins_Vitamins_MaVitamin",
                table: "DotUongVitamins",
                column: "MaVitamin",
                principalTable: "Vitamins",
                principalColumn: "MaVitamin",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GiaoVienChuNhiems_LopHocs_MaLopHoc",
                table: "GiaoVienChuNhiems",
                column: "MaLopHoc",
                principalTable: "LopHocs",
                principalColumn: "MaLop",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GiaoVienChuNhiems_NhanSus_MaNhanSu",
                table: "GiaoVienChuNhiems",
                column: "MaNhanSu",
                principalTable: "NhanSus",
                principalColumn: "MaNhanSu",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HocSinhs_DanTocs_MaDanToc",
                table: "HocSinhs",
                column: "MaDanToc",
                principalTable: "DanTocs",
                principalColumn: "MaDanToc");

            migrationBuilder.AddForeignKey(
                name: "FK_HocSinhs_GioiTinh_MaGioiTinh",
                table: "HocSinhs",
                column: "MaGioiTinh",
                principalTable: "GioiTinh",
                principalColumn: "MaGioiTinh",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HocSinhs_KhoiLops_MaKhoiLop",
                table: "HocSinhs",
                column: "MaKhoiLop",
                principalTable: "KhoiLops",
                principalColumn: "MaKhoiLop",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HocSinhs_LopHocs_MaLopHoc",
                table: "HocSinhs",
                column: "MaLopHoc",
                principalTable: "LopHocs",
                principalColumn: "MaLop");

            migrationBuilder.AddForeignKey(
                name: "FK_HocSinhs_QuocGias_MaQuocTich",
                table: "HocSinhs",
                column: "MaQuocTich",
                principalTable: "QuocGias",
                principalColumn: "MaQuocGia");

            migrationBuilder.AddForeignKey(
                name: "FK_HocSinhs_TonGiaos_MaTonGiao",
                table: "HocSinhs",
                column: "MaTonGiao",
                principalTable: "TonGiaos",
                principalColumn: "MaTonGiao");

            migrationBuilder.AddForeignKey(
                name: "FK_HocSinhs_TrangThaiHocs_MaTrangThaiHoc",
                table: "HocSinhs",
                column: "MaTrangThaiHoc",
                principalTable: "TrangThaiHocs",
                principalColumn: "MaTrangThai",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HocSinhs_TrangThaiTaiKhoans_MaTrangThaiTaiKhoan",
                table: "HocSinhs",
                column: "MaTrangThaiTaiKhoan",
                principalTable: "TrangThaiTaiKhoans",
                principalColumn: "MaTrangThai",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LopHocs_KhoiLops_MaKhoiLop",
                table: "LopHocs",
                column: "MaKhoiLop",
                principalTable: "KhoiLops",
                principalColumn: "MaKhoiLop",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LopHocs_NienHocs_MaNienHoc",
                table: "LopHocs",
                column: "MaNienHoc",
                principalTable: "NienHocs",
                principalColumn: "MaNienHoc",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanSus_ChucVus_MaChucVu",
                table: "NhanSus",
                column: "MaChucVu",
                principalTable: "ChucVus",
                principalColumn: "MaChucVu");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanSus_DanTocs_MaDanToc",
                table: "NhanSus",
                column: "MaDanToc",
                principalTable: "DanTocs",
                principalColumn: "MaDanToc",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanSus_GioiTinh_MaGioiTinh",
                table: "NhanSus",
                column: "MaGioiTinh",
                principalTable: "GioiTinh",
                principalColumn: "MaGioiTinh",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanSus_KhoiLops_MaKhoiLop",
                table: "NhanSus",
                column: "MaKhoiLop",
                principalTable: "KhoiLops",
                principalColumn: "MaKhoiLop");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanSus_LoaiNhanSus_MaLoaiNhanSu",
                table: "NhanSus",
                column: "MaLoaiNhanSu",
                principalTable: "LoaiNhanSus",
                principalColumn: "MaLoaiNhanSu",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanSus_PhongBans_MaPhongBan",
                table: "NhanSus",
                column: "MaPhongBan",
                principalTable: "PhongBans",
                principalColumn: "MaPhongBan",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanSus_QuocGias_MaQuocTich",
                table: "NhanSus",
                column: "MaQuocTich",
                principalTable: "QuocGias",
                principalColumn: "MaQuocGia",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanSus_TonGiaos_MaTonGiao",
                table: "NhanSus",
                column: "MaTonGiao",
                principalTable: "TonGiaos",
                principalColumn: "MaTonGiao",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanSus_TrangThaiLamViecs_MaTrangThaiLamViec",
                table: "NhanSus",
                column: "MaTrangThaiLamViec",
                principalTable: "TrangThaiLamViecs",
                principalColumn: "MaTrangThai",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanSus_TrangThaiTaiKhoans_MaTrangThaiTaiKhoan",
                table: "NhanSus",
                column: "MaTrangThaiTaiKhoan",
                principalTable: "TrangThaiTaiKhoans",
                principalColumn: "MaTrangThai",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuNhapThucPhams_NhanSus_MaNguoiNhap",
                table: "PhieuNhapThucPhams",
                column: "MaNguoiNhap",
                principalTable: "NhanSus",
                principalColumn: "MaNhanSu",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuSoGiuns_DotSoGiuns_MaDotSoGiun",
                table: "PhieuSoGiuns",
                column: "MaDotSoGiun",
                principalTable: "DotSoGiuns",
                principalColumn: "MaDotSoGiun",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuSoGiuns_HocSinhs_MaHocSinh",
                table: "PhieuSoGiuns",
                column: "MaHocSinh",
                principalTable: "HocSinhs",
                principalColumn: "MaHocSinh",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuTiemVaccines_DotTiemVaccines_MaDotTiemVaccine",
                table: "PhieuTiemVaccines",
                column: "MaDotTiemVaccine",
                principalTable: "DotTiemVaccines",
                principalColumn: "MaDotTiemVaccine",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuTiemVaccines_HocSinhs_MaHocSinh",
                table: "PhieuTiemVaccines",
                column: "MaHocSinh",
                principalTable: "HocSinhs",
                principalColumn: "MaHocSinh",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuUongVitamins_DotUongVitamins_MaDotUongVitamin",
                table: "PhieuUongVitamins",
                column: "MaDotUongVitamin",
                principalTable: "DotUongVitamins",
                principalColumn: "MaDotUongVitamin",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuUongVitamins_HocSinhs_MaHocSinh",
                table: "PhieuUongVitamins",
                column: "MaHocSinh",
                principalTable: "HocSinhs",
                principalColumn: "MaHocSinh",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuXuatThucPhams_NhanSus_MaNguoiXuat",
                table: "PhieuXuatThucPhams",
                column: "MaNguoiXuat",
                principalTable: "NhanSus",
                principalColumn: "MaNhanSu",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ThucDonMonAns_MonAns_MaMonAn",
                table: "ThucDonMonAns",
                column: "MaMonAn",
                principalTable: "MonAns",
                principalColumn: "MaMonAn",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ThucDonMonAns_ThucDons_MaThucDon",
                table: "ThucDonMonAns",
                column: "MaThucDon",
                principalTable: "ThucDons",
                principalColumn: "MaThucDon",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ThucDons_DanhMucThucDons_MaDanhMuc",
                table: "ThucDons",
                column: "MaDanhMuc",
                principalTable: "DanhMucThucDons",
                principalColumn: "MaDanhMuc",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ThucPhams_DanhMucThucPhams_MaDanhMuc",
                table: "ThucPhams",
                column: "MaDanhMuc",
                principalTable: "DanhMucThucPhams",
                principalColumn: "MaDanhMuc",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietPhieuNhapThucPhams_PhieuXuatThucPhams_PhieuXuatThucPhamMaPhieuXuatThucPham",
                table: "ChiTietPhieuNhapThucPhams");

            migrationBuilder.DropForeignKey(
                name: "FK_ChucVus_LoaiNhanSus_MaLoaiNhanSu",
                table: "ChucVus");

            migrationBuilder.DropForeignKey(
                name: "FK_DiemDanhs_HocSinhs_MaHocSinh",
                table: "DiemDanhs");

            migrationBuilder.DropForeignKey(
                name: "FK_DiemDanhs_TrangThaiDiemDanhs_MaTrangThaiDiemDanh",
                table: "DiemDanhs");

            migrationBuilder.DropForeignKey(
                name: "FK_DotSoGiuns_NienHocs_MaNienHoc",
                table: "DotSoGiuns");

            migrationBuilder.DropForeignKey(
                name: "FK_DotSoGiuns_ThuocSoGiuns_MaThuocSoGiun",
                table: "DotSoGiuns");

            migrationBuilder.DropForeignKey(
                name: "FK_DotTiemVaccines_NienHocs_MaNienHoc",
                table: "DotTiemVaccines");

            migrationBuilder.DropForeignKey(
                name: "FK_DotTiemVaccines_Vaccines_MaVaccine",
                table: "DotTiemVaccines");

            migrationBuilder.DropForeignKey(
                name: "FK_DotUongVitamins_NienHocs_MaNienHoc",
                table: "DotUongVitamins");

            migrationBuilder.DropForeignKey(
                name: "FK_DotUongVitamins_Vitamins_MaVitamin",
                table: "DotUongVitamins");

            migrationBuilder.DropForeignKey(
                name: "FK_GiaoVienChuNhiems_LopHocs_MaLopHoc",
                table: "GiaoVienChuNhiems");

            migrationBuilder.DropForeignKey(
                name: "FK_GiaoVienChuNhiems_NhanSus_MaNhanSu",
                table: "GiaoVienChuNhiems");

            migrationBuilder.DropForeignKey(
                name: "FK_HocSinhs_DanTocs_MaDanToc",
                table: "HocSinhs");

            migrationBuilder.DropForeignKey(
                name: "FK_HocSinhs_GioiTinh_MaGioiTinh",
                table: "HocSinhs");

            migrationBuilder.DropForeignKey(
                name: "FK_HocSinhs_KhoiLops_MaKhoiLop",
                table: "HocSinhs");

            migrationBuilder.DropForeignKey(
                name: "FK_HocSinhs_LopHocs_MaLopHoc",
                table: "HocSinhs");

            migrationBuilder.DropForeignKey(
                name: "FK_HocSinhs_QuocGias_MaQuocTich",
                table: "HocSinhs");

            migrationBuilder.DropForeignKey(
                name: "FK_HocSinhs_TonGiaos_MaTonGiao",
                table: "HocSinhs");

            migrationBuilder.DropForeignKey(
                name: "FK_HocSinhs_TrangThaiHocs_MaTrangThaiHoc",
                table: "HocSinhs");

            migrationBuilder.DropForeignKey(
                name: "FK_HocSinhs_TrangThaiTaiKhoans_MaTrangThaiTaiKhoan",
                table: "HocSinhs");

            migrationBuilder.DropForeignKey(
                name: "FK_LopHocs_KhoiLops_MaKhoiLop",
                table: "LopHocs");

            migrationBuilder.DropForeignKey(
                name: "FK_LopHocs_NienHocs_MaNienHoc",
                table: "LopHocs");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanSus_ChucVus_MaChucVu",
                table: "NhanSus");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanSus_DanTocs_MaDanToc",
                table: "NhanSus");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanSus_GioiTinh_MaGioiTinh",
                table: "NhanSus");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanSus_KhoiLops_MaKhoiLop",
                table: "NhanSus");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanSus_LoaiNhanSus_MaLoaiNhanSu",
                table: "NhanSus");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanSus_PhongBans_MaPhongBan",
                table: "NhanSus");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanSus_QuocGias_MaQuocTich",
                table: "NhanSus");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanSus_TonGiaos_MaTonGiao",
                table: "NhanSus");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanSus_TrangThaiLamViecs_MaTrangThaiLamViec",
                table: "NhanSus");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanSus_TrangThaiTaiKhoans_MaTrangThaiTaiKhoan",
                table: "NhanSus");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuNhapThucPhams_NhanSus_MaNguoiNhap",
                table: "PhieuNhapThucPhams");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuSoGiuns_DotSoGiuns_MaDotSoGiun",
                table: "PhieuSoGiuns");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuSoGiuns_HocSinhs_MaHocSinh",
                table: "PhieuSoGiuns");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuTiemVaccines_DotTiemVaccines_MaDotTiemVaccine",
                table: "PhieuTiemVaccines");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuTiemVaccines_HocSinhs_MaHocSinh",
                table: "PhieuTiemVaccines");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuUongVitamins_DotUongVitamins_MaDotUongVitamin",
                table: "PhieuUongVitamins");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuUongVitamins_HocSinhs_MaHocSinh",
                table: "PhieuUongVitamins");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuXuatThucPhams_NhanSus_MaNguoiXuat",
                table: "PhieuXuatThucPhams");

            migrationBuilder.DropForeignKey(
                name: "FK_ThucDonMonAns_MonAns_MaMonAn",
                table: "ThucDonMonAns");

            migrationBuilder.DropForeignKey(
                name: "FK_ThucDonMonAns_ThucDons_MaThucDon",
                table: "ThucDonMonAns");

            migrationBuilder.DropForeignKey(
                name: "FK_ThucDons_DanhMucThucDons_MaDanhMuc",
                table: "ThucDons");

            migrationBuilder.DropForeignKey(
                name: "FK_ThucPhams_DanhMucThucPhams_MaDanhMuc",
                table: "ThucPhams");

            migrationBuilder.DropTable(
                name: "TrangThaiDiemDanhs");

            migrationBuilder.DropIndex(
                name: "IX_ThucPhams_MaDanhMuc",
                table: "ThucPhams");

            migrationBuilder.DropIndex(
                name: "IX_ThucDons_MaDanhMuc",
                table: "ThucDons");

            migrationBuilder.DropIndex(
                name: "IX_ThucDonMonAns_MaMonAn",
                table: "ThucDonMonAns");

            migrationBuilder.DropIndex(
                name: "IX_PhieuXuatThucPhams_MaNguoiXuat",
                table: "PhieuXuatThucPhams");

            migrationBuilder.DropIndex(
                name: "IX_PhieuUongVitamins_MaDotUongVitamin",
                table: "PhieuUongVitamins");

            migrationBuilder.DropIndex(
                name: "IX_PhieuUongVitamins_MaHocSinh",
                table: "PhieuUongVitamins");

            migrationBuilder.DropIndex(
                name: "IX_PhieuTiemVaccines_MaDotTiemVaccine",
                table: "PhieuTiemVaccines");

            migrationBuilder.DropIndex(
                name: "IX_PhieuTiemVaccines_MaHocSinh",
                table: "PhieuTiemVaccines");

            migrationBuilder.DropIndex(
                name: "IX_PhieuSoGiuns_MaDotSoGiun",
                table: "PhieuSoGiuns");

            migrationBuilder.DropIndex(
                name: "IX_PhieuSoGiuns_MaHocSinh",
                table: "PhieuSoGiuns");

            migrationBuilder.DropIndex(
                name: "IX_PhieuNhapThucPhams_MaNguoiNhap",
                table: "PhieuNhapThucPhams");

            migrationBuilder.DropIndex(
                name: "IX_NhanSus_MaChucVu",
                table: "NhanSus");

            migrationBuilder.DropIndex(
                name: "IX_NhanSus_MaDanToc",
                table: "NhanSus");

            migrationBuilder.DropIndex(
                name: "IX_NhanSus_MaGioiTinh",
                table: "NhanSus");

            migrationBuilder.DropIndex(
                name: "IX_NhanSus_MaKhoiLop",
                table: "NhanSus");

            migrationBuilder.DropIndex(
                name: "IX_NhanSus_MaLoaiNhanSu",
                table: "NhanSus");

            migrationBuilder.DropIndex(
                name: "IX_NhanSus_MaPhongBan",
                table: "NhanSus");

            migrationBuilder.DropIndex(
                name: "IX_NhanSus_MaQuocTich",
                table: "NhanSus");

            migrationBuilder.DropIndex(
                name: "IX_NhanSus_MaTonGiao",
                table: "NhanSus");

            migrationBuilder.DropIndex(
                name: "IX_NhanSus_MaTrangThaiLamViec",
                table: "NhanSus");

            migrationBuilder.DropIndex(
                name: "IX_NhanSus_MaTrangThaiTaiKhoan",
                table: "NhanSus");

            migrationBuilder.DropIndex(
                name: "IX_LopHocs_MaKhoiLop",
                table: "LopHocs");

            migrationBuilder.DropIndex(
                name: "IX_LopHocs_MaNienHoc",
                table: "LopHocs");

            migrationBuilder.DropIndex(
                name: "IX_HocSinhs_MaDanToc",
                table: "HocSinhs");

            migrationBuilder.DropIndex(
                name: "IX_HocSinhs_MaGioiTinh",
                table: "HocSinhs");

            migrationBuilder.DropIndex(
                name: "IX_HocSinhs_MaKhoiLop",
                table: "HocSinhs");

            migrationBuilder.DropIndex(
                name: "IX_HocSinhs_MaLopHoc",
                table: "HocSinhs");

            migrationBuilder.DropIndex(
                name: "IX_HocSinhs_MaQuocTich",
                table: "HocSinhs");

            migrationBuilder.DropIndex(
                name: "IX_HocSinhs_MaTonGiao",
                table: "HocSinhs");

            migrationBuilder.DropIndex(
                name: "IX_HocSinhs_MaTrangThaiHoc",
                table: "HocSinhs");

            migrationBuilder.DropIndex(
                name: "IX_HocSinhs_MaTrangThaiTaiKhoan",
                table: "HocSinhs");

            migrationBuilder.DropIndex(
                name: "IX_GiaoVienChuNhiems_MaLopHoc",
                table: "GiaoVienChuNhiems");

            migrationBuilder.DropIndex(
                name: "IX_DotUongVitamins_MaNienHoc",
                table: "DotUongVitamins");

            migrationBuilder.DropIndex(
                name: "IX_DotUongVitamins_MaVitamin",
                table: "DotUongVitamins");

            migrationBuilder.DropIndex(
                name: "IX_DotTiemVaccines_MaNienHoc",
                table: "DotTiemVaccines");

            migrationBuilder.DropIndex(
                name: "IX_DotTiemVaccines_MaVaccine",
                table: "DotTiemVaccines");

            migrationBuilder.DropIndex(
                name: "IX_DotSoGiuns_MaNienHoc",
                table: "DotSoGiuns");

            migrationBuilder.DropIndex(
                name: "IX_DotSoGiuns_MaThuocSoGiun",
                table: "DotSoGiuns");

            migrationBuilder.DropIndex(
                name: "IX_DiemDanhs_MaHocSinh",
                table: "DiemDanhs");

            migrationBuilder.DropIndex(
                name: "IX_DiemDanhs_MaTrangThaiDiemDanh",
                table: "DiemDanhs");

            migrationBuilder.DropIndex(
                name: "IX_ChucVus_MaLoaiNhanSu",
                table: "ChucVus");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietPhieuNhapThucPhams_PhieuXuatThucPhamMaPhieuXuatThucPham",
                table: "ChiTietPhieuNhapThucPhams");

            migrationBuilder.DropColumn(
                name: "MaTrangThaiDiemDanh",
                table: "DiemDanhs");

            migrationBuilder.DropColumn(
                name: "PhieuXuatThucPhamMaPhieuXuatThucPham",
                table: "ChiTietPhieuNhapThucPhams");

            migrationBuilder.AddColumn<int>(
                name: "DanhMucThucPhamMaDanhMuc",
                table: "ThucPhams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DanhMucThucDonMaDanhMuc",
                table: "ThucDons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MonAnMaMonAn",
                table: "ThucDonMonAns",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ThucDonMaThucDon",
                table: "ThucDonMonAns",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaNguoiXuat",
                table: "PhieuXuatThucPhams",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "NguoiXuatMaNhanSu",
                table: "PhieuXuatThucPhams",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaHocSinh",
                table: "PhieuUongVitamins",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "DotUongVitaminMaDotUongVitamin",
                table: "PhieuUongVitamins",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HocSinhMaHocSinh",
                table: "PhieuUongVitamins",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaHocSinh",
                table: "PhieuTiemVaccines",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "DotTiemVaccineMaDotTiemVaccine",
                table: "PhieuTiemVaccines",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HocSinhMaHocSinh",
                table: "PhieuTiemVaccines",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaHocSinh",
                table: "PhieuSoGiuns",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "DotSoGiunMaDotSoGiun",
                table: "PhieuSoGiuns",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HocSinhMaHocSinh",
                table: "PhieuSoGiuns",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaNguoiNhap",
                table: "PhieuNhapThucPhams",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "NguoiNhapMaNhanSu",
                table: "PhieuNhapThucPhams",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaTrangThaiTaiKhoan",
                table: "NhanSus",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AlterColumn<string>(
                name: "MaTrangThaiLamViec",
                table: "NhanSus",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AddColumn<int>(
                name: "ChucVuMaChucVu",
                table: "NhanSus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DanTocMaDanToc",
                table: "NhanSus",
                type: "nvarchar(3)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GioiTinhMaGioiTinh",
                table: "NhanSus",
                type: "nvarchar(1)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KhoiLopMaKhoiLop",
                table: "NhanSus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LoaiNhanSuMaLoaiNhanSu",
                table: "NhanSus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhongBanMaPhongBan",
                table: "NhanSus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QuocTichMaQuocGia",
                table: "NhanSus",
                type: "nvarchar(3)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TonGiaoMaTonGiao",
                table: "NhanSus",
                type: "nvarchar(3)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrangThaiLamViecMaTrangThai",
                table: "NhanSus",
                type: "nvarchar(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrangThaiTaiKhoanMaTrangThai",
                table: "NhanSus",
                type: "nvarchar(1)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KhoiLopMaKhoiLop",
                table: "LopHocs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NienHocMaNienHoc",
                table: "LopHocs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DanTocMaDanToc",
                table: "HocSinhs",
                type: "nvarchar(3)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GioiTinhMaGioiTinh",
                table: "HocSinhs",
                type: "nvarchar(1)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KhoiLopMaKhoiLop",
                table: "HocSinhs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LopHocMaLop",
                table: "HocSinhs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QuocTichMaQuocGia",
                table: "HocSinhs",
                type: "nvarchar(3)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TonGiaoMaTonGiao",
                table: "HocSinhs",
                type: "nvarchar(3)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrangThaiHocMaTrangThai",
                table: "HocSinhs",
                type: "nvarchar(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrangThaiTaiKhoanMaTrangThai",
                table: "HocSinhs",
                type: "nvarchar(1)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LopHocMaLop",
                table: "GiaoVienChuNhiems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NienHocMaNienHoc",
                table: "DotUongVitamins",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VitaminMaVitamin",
                table: "DotUongVitamins",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NienHocMaNienHoc",
                table: "DotTiemVaccines",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VaccineMaVaccine",
                table: "DotTiemVaccines",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NienHocMaNienHoc",
                table: "DotSoGiuns",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ThuocSoGiunMaThuocSoGiun",
                table: "DotSoGiuns",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaHocSinh",
                table: "DiemDanhs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "HocSinhMaHocSinh",
                table: "DiemDanhs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrangThai",
                table: "DiemDanhs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "LoaiNhanSuMaLoaiNhanSu",
                table: "ChucVus",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "HocSinhs",
                keyColumn: "MaHocSinh",
                keyValue: "2020210001",
                column: "NgayCapNhat",
                value: new DateTime(2023, 1, 9, 0, 28, 33, 956, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "NhanSus",
                keyColumn: "MaNhanSu",
                keyValue: "1020210001",
                column: "NgayCapNhat",
                value: new DateTime(2023, 1, 9, 0, 28, 33, 956, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.CreateIndex(
                name: "IX_ThucPhams_DanhMucThucPhamMaDanhMuc",
                table: "ThucPhams",
                column: "DanhMucThucPhamMaDanhMuc");

            migrationBuilder.CreateIndex(
                name: "IX_ThucDons_DanhMucThucDonMaDanhMuc",
                table: "ThucDons",
                column: "DanhMucThucDonMaDanhMuc");

            migrationBuilder.CreateIndex(
                name: "IX_ThucDonMonAns_MonAnMaMonAn",
                table: "ThucDonMonAns",
                column: "MonAnMaMonAn");

            migrationBuilder.CreateIndex(
                name: "IX_ThucDonMonAns_ThucDonMaThucDon",
                table: "ThucDonMonAns",
                column: "ThucDonMaThucDon");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuXuatThucPhams_NguoiXuatMaNhanSu",
                table: "PhieuXuatThucPhams",
                column: "NguoiXuatMaNhanSu");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuUongVitamins_DotUongVitaminMaDotUongVitamin",
                table: "PhieuUongVitamins",
                column: "DotUongVitaminMaDotUongVitamin");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuUongVitamins_HocSinhMaHocSinh",
                table: "PhieuUongVitamins",
                column: "HocSinhMaHocSinh");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuTiemVaccines_DotTiemVaccineMaDotTiemVaccine",
                table: "PhieuTiemVaccines",
                column: "DotTiemVaccineMaDotTiemVaccine");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuTiemVaccines_HocSinhMaHocSinh",
                table: "PhieuTiemVaccines",
                column: "HocSinhMaHocSinh");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuSoGiuns_DotSoGiunMaDotSoGiun",
                table: "PhieuSoGiuns",
                column: "DotSoGiunMaDotSoGiun");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuSoGiuns_HocSinhMaHocSinh",
                table: "PhieuSoGiuns",
                column: "HocSinhMaHocSinh");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhapThucPhams_NguoiNhapMaNhanSu",
                table: "PhieuNhapThucPhams",
                column: "NguoiNhapMaNhanSu");

            migrationBuilder.CreateIndex(
                name: "IX_NhanSus_ChucVuMaChucVu",
                table: "NhanSus",
                column: "ChucVuMaChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_NhanSus_DanTocMaDanToc",
                table: "NhanSus",
                column: "DanTocMaDanToc");

            migrationBuilder.CreateIndex(
                name: "IX_NhanSus_GioiTinhMaGioiTinh",
                table: "NhanSus",
                column: "GioiTinhMaGioiTinh");

            migrationBuilder.CreateIndex(
                name: "IX_NhanSus_KhoiLopMaKhoiLop",
                table: "NhanSus",
                column: "KhoiLopMaKhoiLop");

            migrationBuilder.CreateIndex(
                name: "IX_NhanSus_LoaiNhanSuMaLoaiNhanSu",
                table: "NhanSus",
                column: "LoaiNhanSuMaLoaiNhanSu");

            migrationBuilder.CreateIndex(
                name: "IX_NhanSus_PhongBanMaPhongBan",
                table: "NhanSus",
                column: "PhongBanMaPhongBan");

            migrationBuilder.CreateIndex(
                name: "IX_NhanSus_QuocTichMaQuocGia",
                table: "NhanSus",
                column: "QuocTichMaQuocGia");

            migrationBuilder.CreateIndex(
                name: "IX_NhanSus_TonGiaoMaTonGiao",
                table: "NhanSus",
                column: "TonGiaoMaTonGiao");

            migrationBuilder.CreateIndex(
                name: "IX_NhanSus_TrangThaiLamViecMaTrangThai",
                table: "NhanSus",
                column: "TrangThaiLamViecMaTrangThai");

            migrationBuilder.CreateIndex(
                name: "IX_NhanSus_TrangThaiTaiKhoanMaTrangThai",
                table: "NhanSus",
                column: "TrangThaiTaiKhoanMaTrangThai");

            migrationBuilder.CreateIndex(
                name: "IX_LopHocs_KhoiLopMaKhoiLop",
                table: "LopHocs",
                column: "KhoiLopMaKhoiLop");

            migrationBuilder.CreateIndex(
                name: "IX_LopHocs_NienHocMaNienHoc",
                table: "LopHocs",
                column: "NienHocMaNienHoc");

            migrationBuilder.CreateIndex(
                name: "IX_HocSinhs_DanTocMaDanToc",
                table: "HocSinhs",
                column: "DanTocMaDanToc");

            migrationBuilder.CreateIndex(
                name: "IX_HocSinhs_GioiTinhMaGioiTinh",
                table: "HocSinhs",
                column: "GioiTinhMaGioiTinh");

            migrationBuilder.CreateIndex(
                name: "IX_HocSinhs_KhoiLopMaKhoiLop",
                table: "HocSinhs",
                column: "KhoiLopMaKhoiLop");

            migrationBuilder.CreateIndex(
                name: "IX_HocSinhs_LopHocMaLop",
                table: "HocSinhs",
                column: "LopHocMaLop");

            migrationBuilder.CreateIndex(
                name: "IX_HocSinhs_QuocTichMaQuocGia",
                table: "HocSinhs",
                column: "QuocTichMaQuocGia");

            migrationBuilder.CreateIndex(
                name: "IX_HocSinhs_TonGiaoMaTonGiao",
                table: "HocSinhs",
                column: "TonGiaoMaTonGiao");

            migrationBuilder.CreateIndex(
                name: "IX_HocSinhs_TrangThaiHocMaTrangThai",
                table: "HocSinhs",
                column: "TrangThaiHocMaTrangThai");

            migrationBuilder.CreateIndex(
                name: "IX_HocSinhs_TrangThaiTaiKhoanMaTrangThai",
                table: "HocSinhs",
                column: "TrangThaiTaiKhoanMaTrangThai");

            migrationBuilder.CreateIndex(
                name: "IX_GiaoVienChuNhiems_LopHocMaLop",
                table: "GiaoVienChuNhiems",
                column: "LopHocMaLop");

            migrationBuilder.CreateIndex(
                name: "IX_DotUongVitamins_NienHocMaNienHoc",
                table: "DotUongVitamins",
                column: "NienHocMaNienHoc");

            migrationBuilder.CreateIndex(
                name: "IX_DotUongVitamins_VitaminMaVitamin",
                table: "DotUongVitamins",
                column: "VitaminMaVitamin");

            migrationBuilder.CreateIndex(
                name: "IX_DotTiemVaccines_NienHocMaNienHoc",
                table: "DotTiemVaccines",
                column: "NienHocMaNienHoc");

            migrationBuilder.CreateIndex(
                name: "IX_DotTiemVaccines_VaccineMaVaccine",
                table: "DotTiemVaccines",
                column: "VaccineMaVaccine");

            migrationBuilder.CreateIndex(
                name: "IX_DotSoGiuns_NienHocMaNienHoc",
                table: "DotSoGiuns",
                column: "NienHocMaNienHoc");

            migrationBuilder.CreateIndex(
                name: "IX_DotSoGiuns_ThuocSoGiunMaThuocSoGiun",
                table: "DotSoGiuns",
                column: "ThuocSoGiunMaThuocSoGiun");

            migrationBuilder.CreateIndex(
                name: "IX_DiemDanhs_HocSinhMaHocSinh",
                table: "DiemDanhs",
                column: "HocSinhMaHocSinh");

            migrationBuilder.CreateIndex(
                name: "IX_ChucVus_LoaiNhanSuMaLoaiNhanSu",
                table: "ChucVus",
                column: "LoaiNhanSuMaLoaiNhanSu");

            migrationBuilder.AddForeignKey(
                name: "FK_ChucVus_LoaiNhanSus_LoaiNhanSuMaLoaiNhanSu",
                table: "ChucVus",
                column: "LoaiNhanSuMaLoaiNhanSu",
                principalTable: "LoaiNhanSus",
                principalColumn: "MaLoaiNhanSu");

            migrationBuilder.AddForeignKey(
                name: "FK_DiemDanhs_HocSinhs_HocSinhMaHocSinh",
                table: "DiemDanhs",
                column: "HocSinhMaHocSinh",
                principalTable: "HocSinhs",
                principalColumn: "MaHocSinh");

            migrationBuilder.AddForeignKey(
                name: "FK_DotSoGiuns_NienHocs_NienHocMaNienHoc",
                table: "DotSoGiuns",
                column: "NienHocMaNienHoc",
                principalTable: "NienHocs",
                principalColumn: "MaNienHoc");

            migrationBuilder.AddForeignKey(
                name: "FK_DotSoGiuns_ThuocSoGiuns_ThuocSoGiunMaThuocSoGiun",
                table: "DotSoGiuns",
                column: "ThuocSoGiunMaThuocSoGiun",
                principalTable: "ThuocSoGiuns",
                principalColumn: "MaThuocSoGiun");

            migrationBuilder.AddForeignKey(
                name: "FK_DotTiemVaccines_NienHocs_NienHocMaNienHoc",
                table: "DotTiemVaccines",
                column: "NienHocMaNienHoc",
                principalTable: "NienHocs",
                principalColumn: "MaNienHoc");

            migrationBuilder.AddForeignKey(
                name: "FK_DotTiemVaccines_Vaccines_VaccineMaVaccine",
                table: "DotTiemVaccines",
                column: "VaccineMaVaccine",
                principalTable: "Vaccines",
                principalColumn: "MaVaccine");

            migrationBuilder.AddForeignKey(
                name: "FK_DotUongVitamins_NienHocs_NienHocMaNienHoc",
                table: "DotUongVitamins",
                column: "NienHocMaNienHoc",
                principalTable: "NienHocs",
                principalColumn: "MaNienHoc");

            migrationBuilder.AddForeignKey(
                name: "FK_DotUongVitamins_Vitamins_VitaminMaVitamin",
                table: "DotUongVitamins",
                column: "VitaminMaVitamin",
                principalTable: "Vitamins",
                principalColumn: "MaVitamin");

            migrationBuilder.AddForeignKey(
                name: "FK_GiaoVienChuNhiems_LopHocs_LopHocMaLop",
                table: "GiaoVienChuNhiems",
                column: "LopHocMaLop",
                principalTable: "LopHocs",
                principalColumn: "MaLop");

            migrationBuilder.AddForeignKey(
                name: "FK_GiaoVienChuNhiems_NhanSus_MaNhanSu",
                table: "GiaoVienChuNhiems",
                column: "MaNhanSu",
                principalTable: "NhanSus",
                principalColumn: "MaNhanSu",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HocSinhs_DanTocs_DanTocMaDanToc",
                table: "HocSinhs",
                column: "DanTocMaDanToc",
                principalTable: "DanTocs",
                principalColumn: "MaDanToc");

            migrationBuilder.AddForeignKey(
                name: "FK_HocSinhs_GioiTinh_GioiTinhMaGioiTinh",
                table: "HocSinhs",
                column: "GioiTinhMaGioiTinh",
                principalTable: "GioiTinh",
                principalColumn: "MaGioiTinh");

            migrationBuilder.AddForeignKey(
                name: "FK_HocSinhs_KhoiLops_KhoiLopMaKhoiLop",
                table: "HocSinhs",
                column: "KhoiLopMaKhoiLop",
                principalTable: "KhoiLops",
                principalColumn: "MaKhoiLop");

            migrationBuilder.AddForeignKey(
                name: "FK_HocSinhs_LopHocs_LopHocMaLop",
                table: "HocSinhs",
                column: "LopHocMaLop",
                principalTable: "LopHocs",
                principalColumn: "MaLop");

            migrationBuilder.AddForeignKey(
                name: "FK_HocSinhs_QuocGias_QuocTichMaQuocGia",
                table: "HocSinhs",
                column: "QuocTichMaQuocGia",
                principalTable: "QuocGias",
                principalColumn: "MaQuocGia");

            migrationBuilder.AddForeignKey(
                name: "FK_HocSinhs_TonGiaos_TonGiaoMaTonGiao",
                table: "HocSinhs",
                column: "TonGiaoMaTonGiao",
                principalTable: "TonGiaos",
                principalColumn: "MaTonGiao");

            migrationBuilder.AddForeignKey(
                name: "FK_HocSinhs_TrangThaiHocs_TrangThaiHocMaTrangThai",
                table: "HocSinhs",
                column: "TrangThaiHocMaTrangThai",
                principalTable: "TrangThaiHocs",
                principalColumn: "MaTrangThai");

            migrationBuilder.AddForeignKey(
                name: "FK_HocSinhs_TrangThaiTaiKhoans_TrangThaiTaiKhoanMaTrangThai",
                table: "HocSinhs",
                column: "TrangThaiTaiKhoanMaTrangThai",
                principalTable: "TrangThaiTaiKhoans",
                principalColumn: "MaTrangThai");

            migrationBuilder.AddForeignKey(
                name: "FK_LopHocs_KhoiLops_KhoiLopMaKhoiLop",
                table: "LopHocs",
                column: "KhoiLopMaKhoiLop",
                principalTable: "KhoiLops",
                principalColumn: "MaKhoiLop");

            migrationBuilder.AddForeignKey(
                name: "FK_LopHocs_NienHocs_NienHocMaNienHoc",
                table: "LopHocs",
                column: "NienHocMaNienHoc",
                principalTable: "NienHocs",
                principalColumn: "MaNienHoc");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanSus_ChucVus_ChucVuMaChucVu",
                table: "NhanSus",
                column: "ChucVuMaChucVu",
                principalTable: "ChucVus",
                principalColumn: "MaChucVu");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanSus_DanTocs_DanTocMaDanToc",
                table: "NhanSus",
                column: "DanTocMaDanToc",
                principalTable: "DanTocs",
                principalColumn: "MaDanToc");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanSus_GioiTinh_GioiTinhMaGioiTinh",
                table: "NhanSus",
                column: "GioiTinhMaGioiTinh",
                principalTable: "GioiTinh",
                principalColumn: "MaGioiTinh");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanSus_KhoiLops_KhoiLopMaKhoiLop",
                table: "NhanSus",
                column: "KhoiLopMaKhoiLop",
                principalTable: "KhoiLops",
                principalColumn: "MaKhoiLop");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanSus_LoaiNhanSus_LoaiNhanSuMaLoaiNhanSu",
                table: "NhanSus",
                column: "LoaiNhanSuMaLoaiNhanSu",
                principalTable: "LoaiNhanSus",
                principalColumn: "MaLoaiNhanSu");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanSus_PhongBans_PhongBanMaPhongBan",
                table: "NhanSus",
                column: "PhongBanMaPhongBan",
                principalTable: "PhongBans",
                principalColumn: "MaPhongBan");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanSus_QuocGias_QuocTichMaQuocGia",
                table: "NhanSus",
                column: "QuocTichMaQuocGia",
                principalTable: "QuocGias",
                principalColumn: "MaQuocGia");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanSus_TonGiaos_TonGiaoMaTonGiao",
                table: "NhanSus",
                column: "TonGiaoMaTonGiao",
                principalTable: "TonGiaos",
                principalColumn: "MaTonGiao");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanSus_TrangThaiLamViecs_TrangThaiLamViecMaTrangThai",
                table: "NhanSus",
                column: "TrangThaiLamViecMaTrangThai",
                principalTable: "TrangThaiLamViecs",
                principalColumn: "MaTrangThai");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanSus_TrangThaiTaiKhoans_TrangThaiTaiKhoanMaTrangThai",
                table: "NhanSus",
                column: "TrangThaiTaiKhoanMaTrangThai",
                principalTable: "TrangThaiTaiKhoans",
                principalColumn: "MaTrangThai");

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuNhapThucPhams_NhanSus_NguoiNhapMaNhanSu",
                table: "PhieuNhapThucPhams",
                column: "NguoiNhapMaNhanSu",
                principalTable: "NhanSus",
                principalColumn: "MaNhanSu");

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuSoGiuns_DotSoGiuns_DotSoGiunMaDotSoGiun",
                table: "PhieuSoGiuns",
                column: "DotSoGiunMaDotSoGiun",
                principalTable: "DotSoGiuns",
                principalColumn: "MaDotSoGiun");

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuSoGiuns_HocSinhs_HocSinhMaHocSinh",
                table: "PhieuSoGiuns",
                column: "HocSinhMaHocSinh",
                principalTable: "HocSinhs",
                principalColumn: "MaHocSinh");

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuTiemVaccines_DotTiemVaccines_DotTiemVaccineMaDotTiemVaccine",
                table: "PhieuTiemVaccines",
                column: "DotTiemVaccineMaDotTiemVaccine",
                principalTable: "DotTiemVaccines",
                principalColumn: "MaDotTiemVaccine");

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuTiemVaccines_HocSinhs_HocSinhMaHocSinh",
                table: "PhieuTiemVaccines",
                column: "HocSinhMaHocSinh",
                principalTable: "HocSinhs",
                principalColumn: "MaHocSinh");

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuUongVitamins_DotUongVitamins_DotUongVitaminMaDotUongVitamin",
                table: "PhieuUongVitamins",
                column: "DotUongVitaminMaDotUongVitamin",
                principalTable: "DotUongVitamins",
                principalColumn: "MaDotUongVitamin");

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuUongVitamins_HocSinhs_HocSinhMaHocSinh",
                table: "PhieuUongVitamins",
                column: "HocSinhMaHocSinh",
                principalTable: "HocSinhs",
                principalColumn: "MaHocSinh");

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuXuatThucPhams_NhanSus_NguoiXuatMaNhanSu",
                table: "PhieuXuatThucPhams",
                column: "NguoiXuatMaNhanSu",
                principalTable: "NhanSus",
                principalColumn: "MaNhanSu");

            migrationBuilder.AddForeignKey(
                name: "FK_ThucDonMonAns_MonAns_MonAnMaMonAn",
                table: "ThucDonMonAns",
                column: "MonAnMaMonAn",
                principalTable: "MonAns",
                principalColumn: "MaMonAn");

            migrationBuilder.AddForeignKey(
                name: "FK_ThucDonMonAns_ThucDons_ThucDonMaThucDon",
                table: "ThucDonMonAns",
                column: "ThucDonMaThucDon",
                principalTable: "ThucDons",
                principalColumn: "MaThucDon");

            migrationBuilder.AddForeignKey(
                name: "FK_ThucDons_DanhMucThucDons_DanhMucThucDonMaDanhMuc",
                table: "ThucDons",
                column: "DanhMucThucDonMaDanhMuc",
                principalTable: "DanhMucThucDons",
                principalColumn: "MaDanhMuc");

            migrationBuilder.AddForeignKey(
                name: "FK_ThucPhams_DanhMucThucPhams_DanhMucThucPhamMaDanhMuc",
                table: "ThucPhams",
                column: "DanhMucThucPhamMaDanhMuc",
                principalTable: "DanhMucThucPhams",
                principalColumn: "MaDanhMuc");
        }
    }
}
