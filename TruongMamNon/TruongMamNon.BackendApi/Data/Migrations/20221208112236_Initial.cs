using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruongMamNon.BackendApi.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DanhMucThucDons",
                columns: table => new
                {
                    MaDanhMuc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDanhMuc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGian = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NangLuong = table.Column<double>(type: "float", nullable: false),
                    ChatDam = table.Column<double>(type: "float", nullable: false),
                    ChatBeo = table.Column<double>(type: "float", nullable: false),
                    ChatBot = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucThucDons", x => x.MaDanhMuc);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucThucPhams",
                columns: table => new
                {
                    MaDanhMuc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDanhMuc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucThucPhams", x => x.MaDanhMuc);
                });

            migrationBuilder.CreateTable(
                name: "KhoiLops",
                columns: table => new
                {
                    MaKhoiLop = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhoiLop = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoiLops", x => x.MaKhoiLop);
                });

            migrationBuilder.CreateTable(
                name: "LoaiNhanSus",
                columns: table => new
                {
                    MaLoaiNhanSu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiNhanSu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiNhanSus", x => x.MaLoaiNhanSu);
                });

            migrationBuilder.CreateTable(
                name: "MonAns",
                columns: table => new
                {
                    MaMonAn = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenMonAn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NangLuong = table.Column<double>(type: "float", nullable: false),
                    ChatDam = table.Column<double>(type: "float", nullable: false),
                    ChatBeo = table.Column<double>(type: "float", nullable: false),
                    ChatBot = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonAns", x => x.MaMonAn);
                });

            migrationBuilder.CreateTable(
                name: "NienHocs",
                columns: table => new
                {
                    MaNienHoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNienHoc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BatDauHK1 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KetThucHK1 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BatDauHK2 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KetThucHK2 = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NienHocs", x => x.MaNienHoc);
                });

            migrationBuilder.CreateTable(
                name: "PhanQuyens",
                columns: table => new
                {
                    MaQuyen = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenQuyen = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanQuyens", x => x.MaQuyen);
                });

            migrationBuilder.CreateTable(
                name: "PhongBans",
                columns: table => new
                {
                    MaPhongBan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenPhongBan = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongBans", x => x.MaPhongBan);
                });

            migrationBuilder.CreateTable(
                name: "ThuocSoGiuns",
                columns: table => new
                {
                    MaThuocSoGiun = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenThuocSoGiun = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuocSoGiuns", x => x.MaThuocSoGiun);
                });

            migrationBuilder.CreateTable(
                name: "Vaccines",
                columns: table => new
                {
                    MaVaccine = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenVaccine = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccines", x => x.MaVaccine);
                });

            migrationBuilder.CreateTable(
                name: "Vitamins",
                columns: table => new
                {
                    MaVitamin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenVitamin = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vitamins", x => x.MaVitamin);
                });

            migrationBuilder.CreateTable(
                name: "ThucDons",
                columns: table => new
                {
                    MaThucDon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayApDung = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaDanhMuc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThucDons", x => x.MaThucDon);
                    table.ForeignKey(
                        name: "FK_ThucDons_DanhMucThucDons_MaDanhMuc",
                        column: x => x.MaDanhMuc,
                        principalTable: "DanhMucThucDons",
                        principalColumn: "MaDanhMuc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThucPhams",
                columns: table => new
                {
                    MaThucPham = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenThucPham = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DonViTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TonKho = table.Column<double>(type: "float", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaDanhMuc = table.Column<int>(type: "int", nullable: false),
                    NangLuong = table.Column<double>(type: "float", nullable: false),
                    ChatDam = table.Column<double>(type: "float", nullable: false),
                    ChatBeo = table.Column<double>(type: "float", nullable: false),
                    ChatBot = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThucPhams", x => x.MaThucPham);
                    table.ForeignKey(
                        name: "FK_ThucPhams_DanhMucThucPhams_MaDanhMuc",
                        column: x => x.MaDanhMuc,
                        principalTable: "DanhMucThucPhams",
                        principalColumn: "MaDanhMuc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChucVus",
                columns: table => new
                {
                    MaChucVu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChucVu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaLoaiNhanSu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVus", x => x.MaChucVu);
                    table.ForeignKey(
                        name: "FK_ChucVus_LoaiNhanSus_MaLoaiNhanSu",
                        column: x => x.MaLoaiNhanSu,
                        principalTable: "LoaiNhanSus",
                        principalColumn: "MaLoaiNhanSu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LopHocs",
                columns: table => new
                {
                    MaLop = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLop = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MaKhoiLop = table.Column<int>(type: "int", nullable: false),
                    HocPhi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SiSoToiDa = table.Column<int>(type: "int", nullable: false),
                    MaNienHoc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHocs", x => x.MaLop);
                    table.ForeignKey(
                        name: "FK_LopHocs_KhoiLops_MaKhoiLop",
                        column: x => x.MaKhoiLop,
                        principalTable: "KhoiLops",
                        principalColumn: "MaKhoiLop",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LopHocs_NienHocs_MaNienHoc",
                        column: x => x.MaNienHoc,
                        principalTable: "NienHocs",
                        principalColumn: "MaNienHoc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThucDonMonAns",
                columns: table => new
                {
                    MaThucDon = table.Column<int>(type: "int", nullable: false),
                    MaMonAn = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThucDonMonAns", x => new { x.MaThucDon, x.MaMonAn });
                    table.ForeignKey(
                        name: "FK_ThucDonMonAns_MonAns_MaMonAn",
                        column: x => x.MaMonAn,
                        principalTable: "MonAns",
                        principalColumn: "MaMonAn",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ThucDonMonAns_ThucDons_MaThucDon",
                        column: x => x.MaThucDon,
                        principalTable: "ThucDons",
                        principalColumn: "MaThucDon",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonAnThucPhams",
                columns: table => new
                {
                    MaMonAn = table.Column<int>(type: "int", nullable: false),
                    MaThucPham = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonAnThucPhams", x => new { x.MaMonAn, x.MaThucPham });
                    table.ForeignKey(
                        name: "FK_MonAnThucPhams_MonAns_MaMonAn",
                        column: x => x.MaMonAn,
                        principalTable: "MonAns",
                        principalColumn: "MaMonAn",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonAnThucPhams_ThucPhams_MaThucPham",
                        column: x => x.MaThucPham,
                        principalTable: "ThucPhams",
                        principalColumn: "MaThucPham",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NhanSus",
                columns: table => new
                {
                    MaNhanSu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Ho = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", maxLength: 200, nullable: false),
                    NoiSinh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CMND = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NgayCap = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DanToc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TonGiao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    QuocTich = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NgayVaoTruong = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaPhongBan = table.Column<int>(type: "int", nullable: false),
                    TrangThaiLamViec = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LyDoThoiViec = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MaLoaiNhanSu = table.Column<int>(type: "int", nullable: false),
                    MaChucVu = table.Column<int>(type: "int", nullable: true),
                    MaKhoiLop = table.Column<int>(type: "int", nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    HoKhau = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    HinhAnh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MatKhau = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TrangThaiTaiKhoan = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanSus", x => x.MaNhanSu);
                    table.ForeignKey(
                        name: "FK_NhanSus_ChucVus_MaChucVu",
                        column: x => x.MaChucVu,
                        principalTable: "ChucVus",
                        principalColumn: "MaChucVu");
                    table.ForeignKey(
                        name: "FK_NhanSus_KhoiLops_MaKhoiLop",
                        column: x => x.MaKhoiLop,
                        principalTable: "KhoiLops",
                        principalColumn: "MaKhoiLop");
                    table.ForeignKey(
                        name: "FK_NhanSus_LoaiNhanSus_MaLoaiNhanSu",
                        column: x => x.MaLoaiNhanSu,
                        principalTable: "LoaiNhanSus",
                        principalColumn: "MaLoaiNhanSu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NhanSus_PhongBans_MaPhongBan",
                        column: x => x.MaPhongBan,
                        principalTable: "PhongBans",
                        principalColumn: "MaPhongBan",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HocSinhs",
                columns: table => new
                {
                    MaHocSinh = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Ho = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaKhoiLop = table.Column<int>(type: "int", nullable: false),
                    MaLopHoc = table.Column<int>(type: "int", nullable: true),
                    NgayNhapHoc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThaiHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LyDoNghiHoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NoiSinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanToc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TonGiao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuocTich = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoKhau = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatKhau = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TrangThaiTaiKhoan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoTenPhuHuynh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NamSinhPhuHuynh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CMNDPhuHuynh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDTPhuHuynh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgheNghiepPhuHuynh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailPhuHuynh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChiPhuHuynh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocSinhs", x => x.MaHocSinh);
                    table.ForeignKey(
                        name: "FK_HocSinhs_KhoiLops_MaKhoiLop",
                        column: x => x.MaKhoiLop,
                        principalTable: "KhoiLops",
                        principalColumn: "MaKhoiLop",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HocSinhs_LopHocs_MaLopHoc",
                        column: x => x.MaLopHoc,
                        principalTable: "LopHocs",
                        principalColumn: "MaLop");
                });

            migrationBuilder.CreateTable(
                name: "GiaoVienChuNhiems",
                columns: table => new
                {
                    MaNhanSu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaLopHoc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaoVienChuNhiems", x => new { x.MaNhanSu, x.MaLopHoc });
                    table.ForeignKey(
                        name: "FK_GiaoVienChuNhiems_LopHocs_MaLopHoc",
                        column: x => x.MaLopHoc,
                        principalTable: "LopHocs",
                        principalColumn: "MaLop",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GiaoVienChuNhiems_NhanSus_MaNhanSu",
                        column: x => x.MaNhanSu,
                        principalTable: "NhanSus",
                        principalColumn: "MaNhanSu",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NhanSuPhanQuyens",
                columns: table => new
                {
                    MaNhanSu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaQuyen = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanSuPhanQuyens", x => new { x.MaNhanSu, x.MaQuyen });
                    table.ForeignKey(
                        name: "FK_NhanSuPhanQuyens_NhanSus_MaNhanSu",
                        column: x => x.MaNhanSu,
                        principalTable: "NhanSus",
                        principalColumn: "MaNhanSu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NhanSuPhanQuyens_PhanQuyens_MaQuyen",
                        column: x => x.MaQuyen,
                        principalTable: "PhanQuyens",
                        principalColumn: "MaQuyen",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuNhapThucPhams",
                columns: table => new
                {
                    MaPhieuNhapThucPham = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayNhap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaNguoiNhap = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuNhapThucPhams", x => x.MaPhieuNhapThucPham);
                    table.ForeignKey(
                        name: "FK_PhieuNhapThucPhams_NhanSus_MaNguoiNhap",
                        column: x => x.MaNguoiNhap,
                        principalTable: "NhanSus",
                        principalColumn: "MaNhanSu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuXuatThucPhams",
                columns: table => new
                {
                    MaPhieuXuatThucPham = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayXuat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaNguoiXuat = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuXuatThucPhams", x => x.MaPhieuXuatThucPham);
                    table.ForeignKey(
                        name: "FK_PhieuXuatThucPhams_NhanSus_MaNguoiXuat",
                        column: x => x.MaNguoiXuat,
                        principalTable: "NhanSus",
                        principalColumn: "MaNhanSu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiemDanhs",
                columns: table => new
                {
                    MaDiemDanh = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayDiemDanh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaHocSinh = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiemDanhs", x => x.MaDiemDanh);
                    table.ForeignKey(
                        name: "FK_DiemDanhs_HocSinhs_MaHocSinh",
                        column: x => x.MaHocSinh,
                        principalTable: "HocSinhs",
                        principalColumn: "MaHocSinh",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhamSucKhoes",
                columns: table => new
                {
                    MaKhamSucKhoe = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDotKham = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NgayKham = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KetLuan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaHocSinh = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ChieuCao = table.Column<int>(type: "int", nullable: false),
                    CanNang = table.Column<int>(type: "int", nullable: false),
                    BMI = table.Column<double>(type: "float", nullable: false),
                    NhipTim = table.Column<int>(type: "int", nullable: false),
                    TamThu = table.Column<int>(type: "int", nullable: false),
                    TamTruong = table.Column<int>(type: "int", nullable: false),
                    LoaiTheLuc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TuanHoan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoHap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TieuHoa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThanTietNieu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThanKinhTamThan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LamSangKhac = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatPhaiKhongKinh = table.Column<int>(type: "int", nullable: false),
                    MatTraiKhongKinh = table.Column<int>(type: "int", nullable: false),
                    MatPhaiCoKinh = table.Column<int>(type: "int", nullable: false),
                    MatTraiCoKinh = table.Column<int>(type: "int", nullable: false),
                    CacBenhVeMat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaiTraiNoiThuong = table.Column<int>(type: "int", nullable: false),
                    TaiTraiNoiTham = table.Column<int>(type: "int", nullable: false),
                    TaiPhaiNoiThuong = table.Column<int>(type: "int", nullable: false),
                    TaiPhaiNoiTham = table.Column<int>(type: "int", nullable: false),
                    CacBenhTaiMuiHong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HamTren = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HamDuoi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CacBenhRangHamMat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhamSucKhoes", x => x.MaKhamSucKhoe);
                    table.ForeignKey(
                        name: "FK_KhamSucKhoes_HocSinhs_MaHocSinh",
                        column: x => x.MaHocSinh,
                        principalTable: "HocSinhs",
                        principalColumn: "MaHocSinh",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuSoGiuns",
                columns: table => new
                {
                    MaThuocSoGiun = table.Column<int>(type: "int", nullable: false),
                    NgaySoGiun = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaHocSinh = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuSoGiuns", x => new { x.MaThuocSoGiun, x.NgaySoGiun, x.MaHocSinh });
                    table.ForeignKey(
                        name: "FK_PhieuSoGiuns_HocSinhs_MaHocSinh",
                        column: x => x.MaHocSinh,
                        principalTable: "HocSinhs",
                        principalColumn: "MaHocSinh",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhieuSoGiuns_ThuocSoGiuns_MaThuocSoGiun",
                        column: x => x.MaThuocSoGiun,
                        principalTable: "ThuocSoGiuns",
                        principalColumn: "MaThuocSoGiun",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuTiemVaccines",
                columns: table => new
                {
                    MaVaccine = table.Column<int>(type: "int", nullable: false),
                    NgayTiem = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaHocSinh = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuTiemVaccines", x => new { x.MaVaccine, x.NgayTiem, x.MaHocSinh });
                    table.ForeignKey(
                        name: "FK_PhieuTiemVaccines_HocSinhs_MaHocSinh",
                        column: x => x.MaHocSinh,
                        principalTable: "HocSinhs",
                        principalColumn: "MaHocSinh",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhieuTiemVaccines_Vaccines_MaVaccine",
                        column: x => x.MaVaccine,
                        principalTable: "Vaccines",
                        principalColumn: "MaVaccine",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuUongVitamins",
                columns: table => new
                {
                    MaVitamin = table.Column<int>(type: "int", nullable: false),
                    NgayUong = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaHocSinh = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuUongVitamins", x => new { x.MaVitamin, x.NgayUong, x.MaHocSinh });
                    table.ForeignKey(
                        name: "FK_PhieuUongVitamins_HocSinhs_MaHocSinh",
                        column: x => x.MaHocSinh,
                        principalTable: "HocSinhs",
                        principalColumn: "MaHocSinh",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhieuUongVitamins_Vitamins_MaVitamin",
                        column: x => x.MaVitamin,
                        principalTable: "Vitamins",
                        principalColumn: "MaVitamin",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuNhapThucPhams",
                columns: table => new
                {
                    MaPhieuNhapThucPham = table.Column<long>(type: "bigint", nullable: false),
                    MaThucPham = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuong = table.Column<double>(type: "float", nullable: false),
                    PhieuXuatThucPhamMaPhieuXuatThucPham = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuNhapThucPhams", x => new { x.MaPhieuNhapThucPham, x.MaThucPham });
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuNhapThucPhams_PhieuNhapThucPhams_MaPhieuNhapThucPham",
                        column: x => x.MaPhieuNhapThucPham,
                        principalTable: "PhieuNhapThucPhams",
                        principalColumn: "MaPhieuNhapThucPham",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuNhapThucPhams_PhieuXuatThucPhams_PhieuXuatThucPhamMaPhieuXuatThucPham",
                        column: x => x.PhieuXuatThucPhamMaPhieuXuatThucPham,
                        principalTable: "PhieuXuatThucPhams",
                        principalColumn: "MaPhieuXuatThucPham");
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuNhapThucPhams_ThucPhams_MaThucPham",
                        column: x => x.MaThucPham,
                        principalTable: "ThucPhams",
                        principalColumn: "MaThucPham",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuXuatThucPhams",
                columns: table => new
                {
                    MaPhieuXuatThucPham = table.Column<long>(type: "bigint", nullable: false),
                    MaThucPham = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuong = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuXuatThucPhams", x => new { x.MaPhieuXuatThucPham, x.MaThucPham });
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuXuatThucPhams_PhieuXuatThucPhams_MaPhieuXuatThucPham",
                        column: x => x.MaPhieuXuatThucPham,
                        principalTable: "PhieuXuatThucPhams",
                        principalColumn: "MaPhieuXuatThucPham",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuXuatThucPhams_ThucPhams_MaThucPham",
                        column: x => x.MaThucPham,
                        principalTable: "ThucPhams",
                        principalColumn: "MaThucPham",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DanhMucThucDons",
                columns: new[] { "MaDanhMuc", "ChatBeo", "ChatBot", "ChatDam", "GhiChu", "NangLuong", "TenDanhMuc", "ThoiGian" },
                values: new object[] { 1, 10.0, 30.0, 20.0, "", 100.0, "Thực đơn lớp mầm bữa sáng", "07:30" });

            migrationBuilder.InsertData(
                table: "DanhMucThucPhams",
                columns: new[] { "MaDanhMuc", "GhiChu", "TenDanhMuc" },
                values: new object[,]
                {
                    { 1, "", "Ngũ cốc" },
                    { 2, "", "Thịt và các sản phẩm từ thịt" },
                    { 3, "", "Thủy sản và sản phẩm thủy sản" },
                    { 4, "", "Rau, củ, quả và sản phẩm rau, củ, quả" },
                    { 5, "", "Trứng và các sản phẩm từ trứng" },
                    { 6, "", "Sữa tươi nguyên liệu" },
                    { 7, "", "Mật ong và các sản phẩm từ mật ong" },
                    { 8, "", "Gia vị" },
                    { 9, "", "Thực phẩm khác" }
                });

            migrationBuilder.InsertData(
                table: "KhoiLops",
                columns: new[] { "MaKhoiLop", "GhiChu", "TenKhoiLop" },
                values: new object[,]
                {
                    { 1, "", "3-12 tháng - KL0312" },
                    { 2, "", "25-36 tháng - KL2536" },
                    { 3, "", "13-24 tháng - KL1324" },
                    { 4, "", "3-4 tuổi - KLM" },
                    { 5, "", "4-5 tuổi - KLC" },
                    { 6, "", "5-6 tuổi - KLL" }
                });

            migrationBuilder.InsertData(
                table: "LoaiNhanSus",
                columns: new[] { "MaLoaiNhanSu", "GhiChu", "TenLoaiNhanSu" },
                values: new object[,]
                {
                    { 1, "", "Cán bộ quản lý" },
                    { 2, "", "Nhân viên" },
                    { 3, "", "Giáo viên" },
                    { 4, "", "Trưởng phó phòng/ban" }
                });

            migrationBuilder.InsertData(
                table: "MonAns",
                columns: new[] { "MaMonAn", "ChatBeo", "ChatBot", "ChatDam", "GhiChu", "NangLuong", "TenMonAn" },
                values: new object[,]
                {
                    { 1, 0.0, 0.0, 0.0, "", 0.0, "Chôm chôm" },
                    { 2, 0.0, 0.0, 0.0, "", 0.0, "Thịt heo nạc xào đậu cô ve" }
                });

            migrationBuilder.InsertData(
                table: "NienHocs",
                columns: new[] { "MaNienHoc", "BatDauHK1", "BatDauHK2", "KetThucHK1", "KetThucHK2", "TenNienHoc" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Năm học 2019-2020" },
                    { 2, new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Năm học 2020-2021" },
                    { 3, new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Năm học 2021-2022" },
                    { 4, new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Năm học 2022-2023" }
                });

            migrationBuilder.InsertData(
                table: "PhanQuyens",
                columns: new[] { "MaQuyen", "GhiChu", "TenQuyen" },
                values: new object[,]
                {
                    { 1, "", "Admin" },
                    { 2, "", "Cán bộ quản lý" },
                    { 3, "", "Nhân viên" },
                    { 4, "", "Nhân viên bếp" },
                    { 5, "", "Giáo viên" }
                });

            migrationBuilder.InsertData(
                table: "PhongBans",
                columns: new[] { "MaPhongBan", "GhiChu", "TenPhongBan" },
                values: new object[,]
                {
                    { 1, "", "Văn phòng" },
                    { 2, "", "Phòng ban giám hiệu" },
                    { 3, "", "Phòng hành chính quản trị" },
                    { 4, "", "Phòng y tế" },
                    { 5, "", "Phòng giáo dục thể chất" },
                    { 6, "", "Phòng giáo dục nghệ thuật" },
                    { 7, "", "Phòng giáo viên" },
                    { 8, "", "Nhà bếp" }
                });

            migrationBuilder.InsertData(
                table: "ThuocSoGiuns",
                columns: new[] { "MaThuocSoGiun", "GhiChu", "TenThuocSoGiun" },
                values: new object[,]
                {
                    { 1, "Để tẩy giun, trẻ chỉ cần uống một lần duy nhất gồm viên nén định lượng 500 mg vào buổi sáng để đạt hiệu quả tẩy giun tối ưu. ", "Thuốc tẩy giun Mebendazol" },
                    { 2, "Để tính toán liều dùng phù hợp, cha mẹ cần dựa trên cân nặng của trẻ với lượng tương ứng là 10mg cho mỗi kg cân nặng, trẻ cần uống 1 liều duy nhất để tẩy giun hiệu quả.", "Thuốc tẩy giun Pyrantel" },
                    { 3, "Loại thuốc tẩy giun này được sản xuất ở dạng viên nén 400mg uống duy nhất 1 lần, được khuyến cáo nên sử dụng vào buổi sáng.", "Thuốc tẩy giun Albendazole" }
                });

            migrationBuilder.InsertData(
                table: "Vaccines",
                columns: new[] { "MaVaccine", "GhiChu", "TenVaccine" },
                values: new object[,]
                {
                    { 1, "", "Vắc xin cúm mùa" },
                    { 2, "", "Vắc xin phòng viêm phổi, viêm tai giữa, viêm màng não, nhiễm khuẩn huyết do phế cầu khuẩn" },
                    { 3, "", "Vắc xin Bạch hầu – Ho gà – Uốn ván" },
                    { 4, "", "Vắc xin Sởi – Quai bị – Rubella" },
                    { 5, "", "Vắc xin phòng viêm phổi, viêm tai giữa, viêm màng não, nhiễm khuẩn huyết do não mô cầu khuẩn" },
                    { 6, "", "Vắc xin Thủy đậu" },
                    { 7, "", "Vắc xin Viêm não Nhật Bản" },
                    { 8, "", "Vắc xin Viêm gan A+B" },
                    { 9, "", "Vắc xin thương hàn" },
                    { 10, "", "Vắc xin tả" },
                    { 11, "", "Vắc xin dại" }
                });

            migrationBuilder.InsertData(
                table: "Vitamins",
                columns: new[] { "MaVitamin", "GhiChu", "TenVitamin" },
                values: new object[,]
                {
                    { 1, "Uống", "Calci gluconat" },
                    { 2, "Uống", "Vitamin A " },
                    { 3, "Uống", "Vitamin A + D" },
                    { 4, "Uống", "Thiamin hydroclorid" },
                    { 5, "Uống", "Vitamin B2 " },
                    { 6, "Uống", "Vitamin B6" },
                    { 7, "Uống", "Vitamin C" },
                    { 8, "Uống", "Vitamin PP" }
                });

            migrationBuilder.InsertData(
                table: "ChucVus",
                columns: new[] { "MaChucVu", "GhiChu", "MaLoaiNhanSu", "TenChucVu" },
                values: new object[,]
                {
                    { 1, "", 1, "Hiệu trưởng" },
                    { 2, "", 1, "Phó hiệu trưởng" },
                    { 3, "", 4, "Trưởng phòng" },
                    { 4, "", 4, "Phó trưởng phòng" },
                    { 5, "", 2, "Nhân viên y tế" },
                    { 6, "", 2, "Nhân viên khác" },
                    { 7, "", 2, "Nhân viên kế toán" },
                    { 8, "", 2, "Nhân viên văn thư" },
                    { 9, "", 2, "Nhân viên bảo vệ" },
                    { 10, "", 2, "Nhân viên bếp" }
                });

            migrationBuilder.InsertData(
                table: "LopHocs",
                columns: new[] { "MaLop", "HocPhi", "MaKhoiLop", "MaNienHoc", "SiSoToiDa", "TenLop" },
                values: new object[,]
                {
                    { 1, 0m, 4, 4, 80, "Lớp mầm 1" },
                    { 2, 0m, 4, 4, 80, "Lớp mầm 2" },
                    { 3, 0m, 4, 4, 80, "Lớp mầm 3" }
                });

            migrationBuilder.InsertData(
                table: "ThucDons",
                columns: new[] { "MaThucDon", "MaDanhMuc", "NgayApDung", "NgayTao" },
                values: new object[] { 1, 1, new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "ThucPhams",
                columns: new[] { "MaThucPham", "ChatBeo", "ChatBot", "ChatDam", "DonViTinh", "HinhAnh", "MaDanhMuc", "NangLuong", "TenThucPham", "TonKho" },
                values: new object[,]
                {
                    { 1, 0.0, 16400.0, 1500.0, "Kg", "", 4, 72000.0, "Chôm chôm", 0.0 },
                    { 2, 1000.0, 11000.0, 5000.0, "Kg", "", 4, 73000.0, "Đậu cô ve", 0.0 },
                    { 3, 7000.0, 0.0, 19000.0, "Kg", "", 2, 139000.0, "Thịt heo nạc", 0.0 },
                    { 4, 0.0, 11000.0, 900.0, "Kg", "", 4, 48000.0, "Nhãn", 0.0 }
                });

            migrationBuilder.InsertData(
                table: "HocSinhs",
                columns: new[] { "MaHocSinh", "CMNDPhuHuynh", "DanToc", "DiaChi", "DiaChiPhuHuynh", "EmailPhuHuynh", "GhiChu", "GioiTinh", "HinhAnh", "Ho", "HoKhau", "HoTenPhuHuynh", "Id", "LyDoNghiHoc", "MaKhoiLop", "MaLopHoc", "MatKhau", "NamSinhPhuHuynh", "NgayCapNhat", "NgayNhapHoc", "NgaySinh", "NgheNghiepPhuHuynh", "NoiSinh", "QuocTich", "SDTPhuHuynh", "Ten", "TonGiao", "TrangThaiHoc", "TrangThaiTaiKhoan" },
                values: new object[] { "1", "012345678910", "Kinh", "HCM", "140 Lê trọng tấn", "lenguyenductamht@gmail.com", "", "Nam", "", "Lê Nguyễn Đại Đức", "Long An", "Lê Huỳnh Nam", 1, "", 4, 1, "Client@123", new DateTime(1968, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 8, 18, 22, 36, 424, DateTimeKind.Local).AddTicks(8776), new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2001, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tự do", "Long An", "Việt Nam", "0123456789", "Tâm", "Không", "Đang học", "Kích hoạt" });

            migrationBuilder.InsertData(
                table: "MonAnThucPhams",
                columns: new[] { "MaMonAn", "MaThucPham", "SoLuong" },
                values: new object[,]
                {
                    { 1, 1, 0.050000000000000003 },
                    { 2, 2, 0.050000000000000003 },
                    { 2, 3, 0.050000000000000003 }
                });

            migrationBuilder.InsertData(
                table: "NhanSus",
                columns: new[] { "MaNhanSu", "CMND", "DanToc", "DiaChi", "Email", "GioiTinh", "HinhAnh", "Ho", "HoKhau", "Id", "LyDoThoiViec", "MaChucVu", "MaKhoiLop", "MaLoaiNhanSu", "MaPhongBan", "MatKhau", "NgayCap", "NgayCapNhat", "NgaySinh", "NgayVaoTruong", "NoiSinh", "QuocTich", "SoDienThoai", "Ten", "TonGiao", "TrangThaiLamViec", "TrangThaiTaiKhoan" },
                values: new object[] { "1", "123456789", "Kinh", "Tân Phú", "lenguyenductamcv@gmail.com", "Nam", "", "Lê Nguyễn Đại Đức", "Long An", 1, "", 3, null, 1, 1, "Admin@123", null, new DateTime(2022, 12, 8, 18, 22, 36, 424, DateTimeKind.Local).AddTicks(9013), new DateTime(2001, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Long An", "Việt Nam", "123456789", "Tâm", "Không", "Đang làm", "Kích hoạt" });

            migrationBuilder.InsertData(
                table: "ThucDonMonAns",
                columns: new[] { "MaMonAn", "MaThucDon", "SoLuong" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "NhanSuPhanQuyens",
                columns: new[] { "MaNhanSu", "MaQuyen" },
                values: new object[] { "1", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuNhapThucPhams_MaThucPham",
                table: "ChiTietPhieuNhapThucPhams",
                column: "MaThucPham");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuNhapThucPhams_PhieuXuatThucPhamMaPhieuXuatThucPham",
                table: "ChiTietPhieuNhapThucPhams",
                column: "PhieuXuatThucPhamMaPhieuXuatThucPham");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuXuatThucPhams_MaThucPham",
                table: "ChiTietPhieuXuatThucPhams",
                column: "MaThucPham");

            migrationBuilder.CreateIndex(
                name: "IX_ChucVus_MaLoaiNhanSu",
                table: "ChucVus",
                column: "MaLoaiNhanSu");

            migrationBuilder.CreateIndex(
                name: "IX_DiemDanhs_MaHocSinh",
                table: "DiemDanhs",
                column: "MaHocSinh");

            migrationBuilder.CreateIndex(
                name: "IX_GiaoVienChuNhiems_MaLopHoc",
                table: "GiaoVienChuNhiems",
                column: "MaLopHoc");

            migrationBuilder.CreateIndex(
                name: "IX_HocSinhs_MaKhoiLop",
                table: "HocSinhs",
                column: "MaKhoiLop");

            migrationBuilder.CreateIndex(
                name: "IX_HocSinhs_MaLopHoc",
                table: "HocSinhs",
                column: "MaLopHoc");

            migrationBuilder.CreateIndex(
                name: "IX_KhamSucKhoes_MaHocSinh",
                table: "KhamSucKhoes",
                column: "MaHocSinh");

            migrationBuilder.CreateIndex(
                name: "IX_LopHocs_MaKhoiLop",
                table: "LopHocs",
                column: "MaKhoiLop");

            migrationBuilder.CreateIndex(
                name: "IX_LopHocs_MaNienHoc",
                table: "LopHocs",
                column: "MaNienHoc");

            migrationBuilder.CreateIndex(
                name: "IX_MonAnThucPhams_MaThucPham",
                table: "MonAnThucPhams",
                column: "MaThucPham");

            migrationBuilder.CreateIndex(
                name: "IX_NhanSuPhanQuyens_MaQuyen",
                table: "NhanSuPhanQuyens",
                column: "MaQuyen");

            migrationBuilder.CreateIndex(
                name: "IX_NhanSus_MaChucVu",
                table: "NhanSus",
                column: "MaChucVu");

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
                name: "IX_PhieuNhapThucPhams_MaNguoiNhap",
                table: "PhieuNhapThucPhams",
                column: "MaNguoiNhap");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuSoGiuns_MaHocSinh",
                table: "PhieuSoGiuns",
                column: "MaHocSinh");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuTiemVaccines_MaHocSinh",
                table: "PhieuTiemVaccines",
                column: "MaHocSinh");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuUongVitamins_MaHocSinh",
                table: "PhieuUongVitamins",
                column: "MaHocSinh");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuXuatThucPhams_MaNguoiXuat",
                table: "PhieuXuatThucPhams",
                column: "MaNguoiXuat");

            migrationBuilder.CreateIndex(
                name: "IX_ThucDonMonAns_MaMonAn",
                table: "ThucDonMonAns",
                column: "MaMonAn");

            migrationBuilder.CreateIndex(
                name: "IX_ThucDons_MaDanhMuc",
                table: "ThucDons",
                column: "MaDanhMuc");

            migrationBuilder.CreateIndex(
                name: "IX_ThucPhams_MaDanhMuc",
                table: "ThucPhams",
                column: "MaDanhMuc");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietPhieuNhapThucPhams");

            migrationBuilder.DropTable(
                name: "ChiTietPhieuXuatThucPhams");

            migrationBuilder.DropTable(
                name: "DiemDanhs");

            migrationBuilder.DropTable(
                name: "GiaoVienChuNhiems");

            migrationBuilder.DropTable(
                name: "KhamSucKhoes");

            migrationBuilder.DropTable(
                name: "MonAnThucPhams");

            migrationBuilder.DropTable(
                name: "NhanSuPhanQuyens");

            migrationBuilder.DropTable(
                name: "PhieuSoGiuns");

            migrationBuilder.DropTable(
                name: "PhieuTiemVaccines");

            migrationBuilder.DropTable(
                name: "PhieuUongVitamins");

            migrationBuilder.DropTable(
                name: "ThucDonMonAns");

            migrationBuilder.DropTable(
                name: "PhieuNhapThucPhams");

            migrationBuilder.DropTable(
                name: "PhieuXuatThucPhams");

            migrationBuilder.DropTable(
                name: "ThucPhams");

            migrationBuilder.DropTable(
                name: "PhanQuyens");

            migrationBuilder.DropTable(
                name: "ThuocSoGiuns");

            migrationBuilder.DropTable(
                name: "Vaccines");

            migrationBuilder.DropTable(
                name: "HocSinhs");

            migrationBuilder.DropTable(
                name: "Vitamins");

            migrationBuilder.DropTable(
                name: "MonAns");

            migrationBuilder.DropTable(
                name: "ThucDons");

            migrationBuilder.DropTable(
                name: "NhanSus");

            migrationBuilder.DropTable(
                name: "DanhMucThucPhams");

            migrationBuilder.DropTable(
                name: "LopHocs");

            migrationBuilder.DropTable(
                name: "DanhMucThucDons");

            migrationBuilder.DropTable(
                name: "ChucVus");

            migrationBuilder.DropTable(
                name: "PhongBans");

            migrationBuilder.DropTable(
                name: "KhoiLops");

            migrationBuilder.DropTable(
                name: "NienHocs");

            migrationBuilder.DropTable(
                name: "LoaiNhanSus");
        }
    }
}
