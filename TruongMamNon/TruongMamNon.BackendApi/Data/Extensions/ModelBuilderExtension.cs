using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KhoiLop>().HasData(
                new KhoiLop() { MaKhoiLop = 1, TenKhoiLop = "3-12 tháng - KL0312", GhiChu = "" },
                new KhoiLop() { MaKhoiLop = 3, TenKhoiLop = "13-24 tháng - KL1324", GhiChu = "" },
                new KhoiLop() { MaKhoiLop = 2, TenKhoiLop = "25-36 tháng - KL2536", GhiChu = "" },
                new KhoiLop() { MaKhoiLop = 4, TenKhoiLop = "3-4 tuổi - KLM", GhiChu = "" },
                new KhoiLop() { MaKhoiLop = 5, TenKhoiLop = "4-5 tuổi - KLC", GhiChu = "" },
                new KhoiLop() { MaKhoiLop = 6, TenKhoiLop = "5-6 tuổi - KLL", GhiChu = "" });

            modelBuilder.Entity<NienHoc>().HasData(
                new NienHoc()
                {
                    MaNienHoc = 1,
                    TenNienHoc = "Năm học 2019-2020",
                    BatDauHK1 = new DateTime(2019, 08, 01),
                    KetThucHK1 = new DateTime(2020, 01, 09),
                    BatDauHK2 = new DateTime(2020, 01, 10),
                    KetThucHK2 = new DateTime(2020, 05, 31),
                },
                new NienHoc()
                {
                    MaNienHoc = 2,
                    TenNienHoc = "Năm học 2020-2021",
                    BatDauHK1 = new DateTime(2020, 08, 01),
                    KetThucHK1 = new DateTime(2021, 01, 09),
                    BatDauHK2 = new DateTime(2021, 01, 10),
                    KetThucHK2 = new DateTime(2021, 05, 31),
                },
                new NienHoc()
                {
                    MaNienHoc = 3,
                    TenNienHoc = "Năm học 2021-2022",
                    BatDauHK1 = new DateTime(2021, 08, 01),
                    KetThucHK1 = new DateTime(2022, 01, 09),
                    BatDauHK2 = new DateTime(2022, 01, 10),
                    KetThucHK2 = new DateTime(2022, 05, 31),
                },
                new NienHoc()
                {
                    MaNienHoc = 4,
                    TenNienHoc = "Năm học 2022-2023",
                    BatDauHK1 = new DateTime(2022, 08, 01),
                    KetThucHK1 = new DateTime(2023, 01, 09),
                    BatDauHK2 = new DateTime(2023, 01, 10),
                    KetThucHK2 = new DateTime(2023, 05, 31),
                });

            modelBuilder.Entity<DanhMucThucPham>().HasData(
                new DanhMucThucPham() { MaDanhMuc = 1, TenDanhMuc = "Ngũ cốc", GhiChu = "" },
                new DanhMucThucPham() { MaDanhMuc = 2, TenDanhMuc = "Thịt và các sản phẩm từ thịt", GhiChu = "" },
                new DanhMucThucPham() { MaDanhMuc = 3, TenDanhMuc = "Thủy sản và sản phẩm thủy sản", GhiChu = "" },
                new DanhMucThucPham() { MaDanhMuc = 4, TenDanhMuc = "Rau, củ, quả và sản phẩm rau, củ, quả", GhiChu = "" },
                new DanhMucThucPham() { MaDanhMuc = 5, TenDanhMuc = "Trứng và các sản phẩm từ trứng", GhiChu = "" },
                new DanhMucThucPham() { MaDanhMuc = 6, TenDanhMuc = "Sữa tươi nguyên liệu", GhiChu = "" },
                new DanhMucThucPham() { MaDanhMuc = 7, TenDanhMuc = "Mật ong và các sản phẩm từ mật ong", GhiChu = "" },
                new DanhMucThucPham() { MaDanhMuc = 8, TenDanhMuc = "Gia vị", GhiChu = "" },
                new DanhMucThucPham() { MaDanhMuc = 9, TenDanhMuc = "Thực phẩm khác", GhiChu = "" });

            modelBuilder.Entity<ThucPham>().HasData(
                new ThucPham()
                {
                    MaThucPham = 1,
                    TenThucPham = "Chôm chôm",
                    DonViTinh = "Kg",
                    TonKho = 0,
                    HinhAnh = "",
                    MaDanhMuc = 4,
                    NangLuong = 72000,
                    ChatDam = 1500,
                    ChatBeo = 0,
                    ChatBot = 16400
                },
                new ThucPham()
                {
                    MaThucPham = 2,
                    TenThucPham = "Đậu cô ve",
                    DonViTinh = "Kg",
                    TonKho = 0,
                    HinhAnh = "",
                    MaDanhMuc = 4,
                    NangLuong = 73000,
                    ChatDam = 5000,
                    ChatBeo = 1000,
                    ChatBot = 11000
                },
                new ThucPham()
                {
                    MaThucPham = 3,
                    TenThucPham = "Thịt heo nạc",
                    DonViTinh = "Kg",
                    TonKho = 0,
                    HinhAnh = "",
                    MaDanhMuc = 2,
                    NangLuong = 139000,
                    ChatDam = 19000,
                    ChatBeo = 7000,
                    ChatBot = 0
                },
                new ThucPham()
                {
                    MaThucPham = 4,
                    TenThucPham = "Nhãn",
                    DonViTinh = "Kg",
                    TonKho = 0,
                    HinhAnh = "",
                    MaDanhMuc = 4,
                    NangLuong = 48000,
                    ChatDam = 900,
                    ChatBeo = 0,
                    ChatBot = 11000
                });

            modelBuilder.Entity<LopHoc>().HasData(
                new LopHoc() { MaLop = 1, TenLop = "Lớp mầm 1", MaKhoiLop = 4, SiSoToiDa = 80, HocPhi = 0, MaNienHoc = 4 },
                new LopHoc() { MaLop = 2, TenLop = "Lớp mầm 2", MaKhoiLop = 4, SiSoToiDa = 80, HocPhi = 0, MaNienHoc = 4 },
                new LopHoc() { MaLop = 3, TenLop = "Lớp mầm 3", MaKhoiLop = 4, SiSoToiDa = 80, HocPhi = 0, MaNienHoc = 4 });

            modelBuilder.Entity<HocSinh>().HasData(
                new HocSinh()
                {
                    Id = 1,
                    MaHocSinh = "1",
                    Ho = "Lê Nguyễn Đại Đức",
                    Ten = "Tâm",
                    GioiTinh = "Nam",
                    MaKhoiLop = 4,
                    MaLopHoc = 1,
                    NgayNhapHoc = new DateTime(2022, 12, 3),
                    TrangThaiHoc = "Đang học",
                    LyDoNghiHoc = "",
                    NgayCapNhat = DateTime.Now,
                    NgaySinh = new DateTime(2001, 1, 10),
                    NoiSinh = "Long An",
                    DanToc = "Kinh",
                    TonGiao = "Không",
                    QuocTich = "Việt Nam",
                    GhiChu = "",
                    HoKhau = "Long An",
                    DiaChi = "HCM",
                    HinhAnh = "",
                    MatKhau = "Client@123",
                    TrangThaiTaiKhoan = "Kích hoạt",
                    HoTenPhuHuynh = "Lê Huỳnh Nam",
                    NamSinhPhuHuynh = new DateTime(1968, 1, 1),
                    CMNDPhuHuynh = "012345678910",
                    SDTPhuHuynh = "0123456789",
                    NgheNghiepPhuHuynh = "Tự do",
                    EmailPhuHuynh = "lenguyenductamht@gmail.com",
                    DiaChiPhuHuynh = "140 Lê trọng tấn",
                });

            modelBuilder.Entity<DanhMucThucDon>().HasData(
                new DanhMucThucDon()
                {
                    MaDanhMuc = 1,
                    TenDanhMuc = "Thực đơn lớp mầm bữa sáng",
                    GhiChu = "",
                    ThoiGian = "07:30",
                    NangLuong = 100,
                    ChatDam = 20,
                    ChatBeo = 10,
                    ChatBot = 30,
                });

            modelBuilder.Entity<ThucDon>().HasData(
                new ThucDon() { MaThucDon = 1, NgayApDung = new DateTime(2022, 12, 5), NgayTao = new DateTime(2022, 12, 3), MaDanhMuc = 1 });

            modelBuilder.Entity<MonAn>().HasData(
                new MonAn() { MaMonAn = 1, TenMonAn = "Chôm chôm", GhiChu = "", NangLuong = 0, ChatDam = 0, ChatBeo = 0, ChatBot = 0 },
                new MonAn() { MaMonAn = 2, TenMonAn = "Thịt heo nạc xào đậu cô ve", GhiChu = "", NangLuong = 0, ChatDam = 0, ChatBeo = 0, ChatBot = 0 });

            modelBuilder.Entity<MonAnThucPham>().HasData(
                new MonAnThucPham() { MaMonAn = 1, MaThucPham = 1, SoLuong = 0.05 },
                new MonAnThucPham() { MaMonAn = 2, MaThucPham = 3, SoLuong = 0.05 },
                new MonAnThucPham() { MaMonAn = 2, MaThucPham = 2, SoLuong = 0.05 });

            modelBuilder.Entity<ThucDonMonAn>().HasData(
                new ThucDonMonAn() { MaThucDon = 1, MaMonAn = 1, SoLuong = 1 },
                new ThucDonMonAn() { MaThucDon = 1, MaMonAn = 2, SoLuong = 1 });

            modelBuilder.Entity<PhanQuyen>().HasData(
                new PhanQuyen() { MaQuyen = 1, TenQuyen = "Admin", GhiChu = "" },
                new PhanQuyen() { MaQuyen = 2, TenQuyen = "Cán bộ quản lý", GhiChu = "" },
                new PhanQuyen() { MaQuyen = 3, TenQuyen = "Nhân viên", GhiChu = "" },
                new PhanQuyen() { MaQuyen = 4, TenQuyen = "Nhân viên bếp", GhiChu = "" },
                new PhanQuyen() { MaQuyen = 5, TenQuyen = "Giáo viên", GhiChu = "" }
                );

            modelBuilder.Entity<LoaiNhanSu>().HasData(
                new LoaiNhanSu() { MaLoaiNhanSu = 1, TenLoaiNhanSu = "Cán bộ quản lý", GhiChu = "" },
                new LoaiNhanSu() { MaLoaiNhanSu = 2, TenLoaiNhanSu = "Nhân viên", GhiChu = "" },
                new LoaiNhanSu() { MaLoaiNhanSu = 3, TenLoaiNhanSu = "Giáo viên", GhiChu = "" },
                new LoaiNhanSu() { MaLoaiNhanSu = 4, TenLoaiNhanSu = "Trưởng phó phòng/ban", GhiChu = "" });

            modelBuilder.Entity<ChucVu>().HasData(
               new ChucVu() { MaChucVu = 1, TenChucVu = "Hiệu trưởng", GhiChu = "", MaLoaiNhanSu = 1 },
               new ChucVu() { MaChucVu = 2, TenChucVu = "Phó hiệu trưởng", GhiChu = "", MaLoaiNhanSu = 1 },
               new ChucVu() { MaChucVu = 3, TenChucVu = "Trưởng phòng", GhiChu = "", MaLoaiNhanSu = 4 },
               new ChucVu() { MaChucVu = 4, TenChucVu = "Phó trưởng phòng", GhiChu = "", MaLoaiNhanSu = 4 },
               new ChucVu() { MaChucVu = 5, TenChucVu = "Nhân viên y tế", GhiChu = "", MaLoaiNhanSu = 2 },
               new ChucVu() { MaChucVu = 6, TenChucVu = "Nhân viên khác", GhiChu = "", MaLoaiNhanSu = 2 },
               new ChucVu() { MaChucVu = 7, TenChucVu = "Nhân viên kế toán", GhiChu = "", MaLoaiNhanSu = 2 },
               new ChucVu() { MaChucVu = 8, TenChucVu = "Nhân viên văn thư", GhiChu = "", MaLoaiNhanSu = 2 },
               new ChucVu() { MaChucVu = 9, TenChucVu = "Nhân viên bảo vệ", GhiChu = "", MaLoaiNhanSu = 2 },
               new ChucVu() { MaChucVu = 10, TenChucVu = "Nhân viên bếp", GhiChu = "", MaLoaiNhanSu = 2 });

            modelBuilder.Entity<PhongBan>().HasData(
               new PhongBan() { MaPhongBan = 1, TenPhongBan = "Văn phòng", GhiChu = "" },
               new PhongBan() { MaPhongBan = 2, TenPhongBan = "Phòng ban giám hiệu", GhiChu = "" },
               new PhongBan() { MaPhongBan = 3, TenPhongBan = "Phòng hành chính quản trị", GhiChu = "" },
               new PhongBan() { MaPhongBan = 4, TenPhongBan = "Phòng y tế", GhiChu = "" },
               new PhongBan() { MaPhongBan = 5, TenPhongBan = "Phòng giáo dục thể chất", GhiChu = "" },
               new PhongBan() { MaPhongBan = 6, TenPhongBan = "Phòng giáo dục nghệ thuật", GhiChu = "" },
               new PhongBan() { MaPhongBan = 7, TenPhongBan = "Phòng giáo viên", GhiChu = "" },
               new PhongBan() { MaPhongBan = 8, TenPhongBan = "Nhà bếp", GhiChu = "" });

            modelBuilder.Entity<NhanSu>().HasData(
               new NhanSu()
               {
                   Id = 1,
                   MaNhanSu = "1",
                   Ho = "Lê Nguyễn Đại Đức",
                   Ten = "Tâm",
                   GioiTinh = "Nam",
                   NgaySinh = new DateTime(2001, 01, 10),
                   NoiSinh = "Long An",
                   CMND = "123456789",
                   NgayCap = null,
                   DanToc = "Kinh",
                   TonGiao = "Không",
                   QuocTich = "Việt Nam",
                   NgayVaoTruong = new DateTime(2020, 01, 10),
                   MaPhongBan = 1,
                   TrangThaiLamViec = "Đang làm",
                   LyDoThoiViec = "",
                   NgayCapNhat = DateTime.Now,
                   MaLoaiNhanSu = 1,
                   MaChucVu = 3,
                   MaKhoiLop = null,
                   SoDienThoai = "123456789",
                   Email = "lenguyenductamcv@gmail.com",
                   HoKhau = "Long An",
                   DiaChi = "Tân Phú",
                   HinhAnh = "",
                   MatKhau = "Admin@123",
                   TrangThaiTaiKhoan = "Kích hoạt",
               });

            modelBuilder.Entity<NhanSuPhanQuyen>().HasData(
              new NhanSuPhanQuyen() { MaNhanSu = "1", MaQuyen = 1 });

            modelBuilder.Entity<Vaccine>().HasData(
                new Vaccine() { MaVaccine = 1, TenVaccine = "Vắc xin cúm mùa", GhiChu = "" },
                new Vaccine() { MaVaccine = 2, TenVaccine = "Vắc xin phòng viêm phổi, viêm tai giữa, viêm màng não, nhiễm khuẩn huyết do phế cầu khuẩn", GhiChu = "" },
                new Vaccine() { MaVaccine = 3, TenVaccine = "Vắc xin Bạch hầu – Ho gà – Uốn ván", GhiChu = "" },
                new Vaccine() { MaVaccine = 4, TenVaccine = "Vắc xin Sởi – Quai bị – Rubella", GhiChu = "" },
                new Vaccine() { MaVaccine = 5, TenVaccine = "Vắc xin phòng viêm phổi, viêm tai giữa, viêm màng não, nhiễm khuẩn huyết do não mô cầu khuẩn", GhiChu = "" },
                new Vaccine() { MaVaccine = 6, TenVaccine = "Vắc xin Thủy đậu", GhiChu = "" },
                new Vaccine() { MaVaccine = 7, TenVaccine = "Vắc xin Viêm não Nhật Bản", GhiChu = "" },
                new Vaccine() { MaVaccine = 8, TenVaccine = "Vắc xin Viêm gan A+B", GhiChu = "" },
                new Vaccine() { MaVaccine = 9, TenVaccine = "Vắc xin thương hàn", GhiChu = "" },
                new Vaccine() { MaVaccine = 10, TenVaccine = "Vắc xin tả", GhiChu = "" },
                new Vaccine() { MaVaccine = 11, TenVaccine = "Vắc xin dại", GhiChu = "" });

            modelBuilder.Entity<ThuocSoGiun>().HasData(
                new ThuocSoGiun() { MaThuocSoGiun = 1, TenThuocSoGiun = "Thuốc tẩy giun Mebendazol", GhiChu = "Để tẩy giun, trẻ chỉ cần uống một lần duy nhất gồm viên nén định lượng 500 mg vào buổi sáng để đạt hiệu quả tẩy giun tối ưu. " },
                new ThuocSoGiun() { MaThuocSoGiun = 2, TenThuocSoGiun = "Thuốc tẩy giun Pyrantel", GhiChu = "Để tính toán liều dùng phù hợp, cha mẹ cần dựa trên cân nặng của trẻ với lượng tương ứng là 10mg cho mỗi kg cân nặng, trẻ cần uống 1 liều duy nhất để tẩy giun hiệu quả." },
                new ThuocSoGiun() { MaThuocSoGiun = 3, TenThuocSoGiun = "Thuốc tẩy giun Albendazole", GhiChu = "Loại thuốc tẩy giun này được sản xuất ở dạng viên nén 400mg uống duy nhất 1 lần, được khuyến cáo nên sử dụng vào buổi sáng." });

            modelBuilder.Entity<Vitamin>().HasData(
                new Vitamin() { MaVitamin = 1, TenVitamin = "Calci gluconat", GhiChu = "Uống" },
                new Vitamin() { MaVitamin = 2, TenVitamin = "Vitamin A ", GhiChu = "Uống" },
                new Vitamin() { MaVitamin = 3, TenVitamin = "Vitamin A + D", GhiChu = "Uống" },
                new Vitamin() { MaVitamin = 4, TenVitamin = "Thiamin hydroclorid", GhiChu = "Uống" },
                new Vitamin() { MaVitamin = 5, TenVitamin = "Vitamin B2 ", GhiChu = "Uống" },
                new Vitamin() { MaVitamin = 6, TenVitamin = "Vitamin B6", GhiChu = "Uống" },
                new Vitamin() { MaVitamin = 7, TenVitamin = "Vitamin C", GhiChu = "Uống" },
                new Vitamin() { MaVitamin = 8, TenVitamin = "Vitamin PP", GhiChu = "Uống" });
        }
    }
}