using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrangThaiDiemDanh>().HasData(
                new TrangThaiDiemDanh() { MaTrangThai = "1", TenTrangThai = "Vắng sáng có phép" },
                new TrangThaiDiemDanh() { MaTrangThai = "2", TenTrangThai = "Vắng sáng không phép" },
                new TrangThaiDiemDanh() { MaTrangThai = "3", TenTrangThai = "Vắng chiều có phép" },
                new TrangThaiDiemDanh() { MaTrangThai = "4", TenTrangThai = "Vắng chiều không phép" },
                new TrangThaiDiemDanh() { MaTrangThai = "5", TenTrangThai = "Vắng cả ngày có phép" },
                new TrangThaiDiemDanh() { MaTrangThai = "6", TenTrangThai = "Vắng cả ngày không phép" }
                );

            modelBuilder.Entity<TrangThaiHoc>().HasData(
                new TrangThaiHoc() { MaTrangThai = "0", TenTrangThai = "Đang học" },
                new TrangThaiHoc() { MaTrangThai = "1", TenTrangThai = "Đã nghỉ" });

            modelBuilder.Entity<TrangThaiLamViec>().HasData(
               new TrangThaiLamViec() { MaTrangThai = "0", TenTrangThai = "Đang làm việc" },
               new TrangThaiLamViec() { MaTrangThai = "1", TenTrangThai = "Đang nghỉ thai sản" },
               new TrangThaiLamViec() { MaTrangThai = "2", TenTrangThai = "Đã nghỉ" });

            modelBuilder.Entity<TrangThaiTaiKhoan>().HasData(
               new TrangThaiTaiKhoan() { MaTrangThai = "0", TenTrangThai = "Kích hoạt" },
               new TrangThaiTaiKhoan() { MaTrangThai = "1", TenTrangThai = "Vô hiệu" });

            modelBuilder.Entity<GioiTinh>().HasData(
                new GioiTinh() { MaGioiTinh = "0", TenGioiTinh = "Nam" },
                new GioiTinh() { MaGioiTinh = "1", TenGioiTinh = "Nữ" },
                new GioiTinh() { MaGioiTinh = "2", TenGioiTinh = "Khác" });

            modelBuilder.Entity<DanToc>().HasData(
                new DanToc() { MaDanToc = "01", TenDanToc = "Kinh" },
                new DanToc() { MaDanToc = "17", TenDanToc = "Chăm" },
                new DanToc() { MaDanToc = "21", TenDanToc = "Ra-glai" },
                new DanToc() { MaDanToc = "12", TenDanToc = "Ê-đê" },
                new DanToc() { MaDanToc = "18", TenDanToc = "Sán Dìu" },
                new DanToc() { MaDanToc = "13", TenDanToc = "Ba-na" },
                new DanToc() { MaDanToc = "19", TenDanToc = "Hrê" },
                new DanToc() { MaDanToc = "36", TenDanToc = "Chu-ru" },
                new DanToc() { MaDanToc = "04", TenDanToc = "Hoa" },
                new DanToc() { MaDanToc = "54", TenDanToc = "Rơ-măm" },
                new DanToc() { MaDanToc = "15", TenDanToc = "Sán Chay" },
                new DanToc() { MaDanToc = "49", TenDanToc = "Bố Y" },
                new DanToc() { MaDanToc = "35", TenDanToc = "Hà Nhì" },
                new DanToc() { MaDanToc = "41", TenDanToc = "La Hủ" },
                new DanToc() { MaDanToc = "45", TenDanToc = "Mảng" },
                new DanToc() { MaDanToc = "11", TenDanToc = "Ngái" },
                new DanToc() { MaDanToc = "40", TenDanToc = "Phù Lá" },
                new DanToc() { MaDanToc = "06", TenDanToc = "Mường" },
                new DanToc() { MaDanToc = "42", TenDanToc = "Lự" },
                new DanToc() { MaDanToc = "37", TenDanToc = "Lào" },
                new DanToc() { MaDanToc = "38", TenDanToc = "La Chi" },
                new DanToc() { MaDanToc = "09", TenDanToc = "Dao" },
                new DanToc() { MaDanToc = "29", TenDanToc = "Khơ-mú" },
                new DanToc() { MaDanToc = "43", TenDanToc = "Lô Lô" },
                new DanToc() { MaDanToc = "53", TenDanToc = "Ơ Đu" },
                new DanToc() { MaDanToc = "51", TenDanToc = "Pu Péo" },
                new DanToc() { MaDanToc = "05", TenDanToc = "Khơ-me" },
                new DanToc() { MaDanToc = "33", TenDanToc = "Kháng" },
                new DanToc() { MaDanToc = "46", TenDanToc = "Pà Thẻn" },
                new DanToc() { MaDanToc = "32", TenDanToc = "Chơ-ro" },
                new DanToc() { MaDanToc = "56", TenDanToc = "Không Xác Định" },
                new DanToc() { MaDanToc = "28", TenDanToc = "Mạ" },
                new DanToc() { MaDanToc = "07", TenDanToc = "Nùng" },
                new DanToc() { MaDanToc = "55", TenDanToc = "Người Nước Ngoài" },
                new DanToc() { MaDanToc = "08", TenDanToc = "Hmông" },
                new DanToc() { MaDanToc = "20", TenDanToc = "Mnông" },
                new DanToc() { MaDanToc = "52", TenDanToc = "Brâu" },
                new DanToc() { MaDanToc = "23", TenDanToc = "Bru-Vân Kiều" },
                new DanToc() { MaDanToc = "44", TenDanToc = "Chứt" },
                new DanToc() { MaDanToc = "30", TenDanToc = "Co" },
                new DanToc() { MaDanToc = "16", TenDanToc = "Cơ-ho" },
                new DanToc() { MaDanToc = "47", TenDanToc = "Cơ Lao" },
                new DanToc() { MaDanToc = "26", TenDanToc = "Cơ-tu" },
                new DanToc() { MaDanToc = "48", TenDanToc = "Cống" },
                new DanToc() { MaDanToc = "10", TenDanToc = "Gia-rai" },
                new DanToc() { MaDanToc = "25", TenDanToc = "Giáy" },
                new DanToc() { MaDanToc = "27", TenDanToc = "Gié-Triêng" },
                new DanToc() { MaDanToc = "50", TenDanToc = "Si La" },
                new DanToc() { MaDanToc = "31", TenDanToc = "Ta-ôi" },
                new DanToc() { MaDanToc = "02", TenDanToc = "Tày" },
                new DanToc() { MaDanToc = "03", TenDanToc = "Thái" },
                new DanToc() { MaDanToc = "24", TenDanToc = "Thổ" },
                new DanToc() { MaDanToc = "34", TenDanToc = "Xinh-mun" },
                new DanToc() { MaDanToc = "14", TenDanToc = "Xơ-đăng" },
                new DanToc() { MaDanToc = "22", TenDanToc = "Xtiêng" });

            modelBuilder.Entity<TonGiao>().HasData(
                new TonGiao { MaTonGiao = "99", TenTonGiao = "Không" },
                new TonGiao { MaTonGiao = "01", TenTonGiao = "Phật giáo" },
                new TonGiao { MaTonGiao = "02", TenTonGiao = "Công giáo" },
                new TonGiao { MaTonGiao = "03", TenTonGiao = "Phật giáo Hòa Hảo " },
                new TonGiao { MaTonGiao = "04", TenTonGiao = "Hồi giáo" },
                new TonGiao { MaTonGiao = "05", TenTonGiao = "Cao Đài" },
                new TonGiao { MaTonGiao = "06", TenTonGiao = "Minh sư đạo" },
                new TonGiao { MaTonGiao = "07", TenTonGiao = "Minh Lý đạo" },
                new TonGiao { MaTonGiao = "08", TenTonGiao = "Tin Lành" },
                new TonGiao { MaTonGiao = "09", TenTonGiao = "Tịnh độ cư sĩ Phật hồi Việt Nam" },
                new TonGiao { MaTonGiao = "10", TenTonGiao = "Đạo tứ ấn hiếu nghĩa" },
                new TonGiao { MaTonGiao = "11", TenTonGiao = "Bửu sơn Kỳ Hương" },
                new TonGiao { MaTonGiao = "12", TenTonGiao = "Ba Ha'i" },
                new TonGiao { MaTonGiao = "13", TenTonGiao = "Tôn giáo khác" });

            modelBuilder.Entity<QuocGia>().HasData(
                new QuocGia { MaQuocGia = "704", TenQuocGia = "Việt Nam" },
                new QuocGia { MaQuocGia = "100", TenQuocGia = "Bungari" },
                new QuocGia { MaQuocGia = "276", TenQuocGia = "Cộng hoà LB Đức" },
                new QuocGia { MaQuocGia = "643", TenQuocGia = "Cộng hoà LB Nga" },
                new QuocGia { MaQuocGia = "348", TenQuocGia = "Hunggari" },
                new QuocGia { MaQuocGia = "703", TenQuocGia = "Slovakia" },
                new QuocGia { MaQuocGia = "09", TenQuocGia = "Tiệp Khắc" },
                new QuocGia { MaQuocGia = "156", TenQuocGia = "Trung Quốc" },
                new QuocGia { MaQuocGia = "764", TenQuocGia = "Thái Lan" },
                new QuocGia { MaQuocGia = "756", TenQuocGia = "Thuỵ Sỹ" },
                new QuocGia { MaQuocGia = "250", TenQuocGia = "Cộng hoà Pháp" },
                new QuocGia { MaQuocGia = "356", TenQuocGia = "Ấn Độ" },
                new QuocGia { MaQuocGia = "418", TenQuocGia = "Cộng hoà CHDCND Lào" },
                new QuocGia { MaQuocGia = "036", TenQuocGia = "Australia" },
                new QuocGia { MaQuocGia = "158", TenQuocGia = "Đài Loan" },
                new QuocGia { MaQuocGia = "392", TenQuocGia = "Nhật Bản" },
                new QuocGia { MaQuocGia = "024", TenQuocGia = "AngoLa" },
                new QuocGia { MaQuocGia = "840", TenQuocGia = "Mỹ" },
                new QuocGia { MaQuocGia = "410", TenQuocGia = "Hàn Quốc" },
                new QuocGia { MaQuocGia = "344", TenQuocGia = "Hồng Kông" },
                new QuocGia { MaQuocGia = "528", TenQuocGia = "Hà Lan" },
                new QuocGia { MaQuocGia = "702", TenQuocGia = "Singapore" },
                new QuocGia { MaQuocGia = "124", TenQuocGia = "Canada" },
                new QuocGia { MaQuocGia = "752", TenQuocGia = "Thụy Điển" },
                new QuocGia { MaQuocGia = "352", TenQuocGia = "BắC Ai Len" },
                new QuocGia { MaQuocGia = "75", TenQuocGia = "Mỹ 2" });

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
                    MaDanhMuc = 4
                },
                new ThucPham()
                {
                    MaThucPham = 2,
                    TenThucPham = "Đậu cô ve",
                    DonViTinh = "Kg",
                    TonKho = 0,
                    MaDanhMuc = 4
                },
                new ThucPham()
                {
                    MaThucPham = 3,
                    TenThucPham = "Thịt heo nạc",
                    DonViTinh = "Kg",
                    TonKho = 0,
                    MaDanhMuc = 2
                },
                new ThucPham()
                {
                    MaThucPham = 4,
                    TenThucPham = "Nhãn",
                    DonViTinh = "Kg",
                    TonKho = 0,
                    MaDanhMuc = 4
                });

            modelBuilder.Entity<LopHoc>().HasData(
                new LopHoc() { MaLop = 1, TenLop = "Lớp mầm 1", MaKhoiLop = 4, SiSoToiDa = 80, HocPhi = 0, MaNienHoc = 4 },
                new LopHoc() { MaLop = 2, TenLop = "Lớp mầm 2", MaKhoiLop = 4, SiSoToiDa = 80, HocPhi = 0, MaNienHoc = 4 },
                new LopHoc() { MaLop = 3, TenLop = "Lớp mầm 3", MaKhoiLop = 4, SiSoToiDa = 80, HocPhi = 0, MaNienHoc = 4 });

            modelBuilder.Entity<HocSinh>().HasData(
                new HocSinh()
                {
                    MaHocSinh = 1,
                    Ho = "Lê Nguyễn Đại Đức",
                    Ten = "Tâm",
                    MaGioiTinh = "0",
                    MaKhoiLop = 4,
                    MaLopHoc = 1,
                    NgayNhapHoc = new DateTime(2022, 12, 3),
                    MaTrangThaiHoc = "0",
                    LyDoNghiHoc = "",
                    NgayCapNhat = DateTime.Now,
                    NgaySinh = new DateTime(2001, 1, 10),
                    NoiSinh = "Long An",
                    MaDanToc = "01",
                    MaTonGiao = "99",
                    MaQuocTich = "704",
                    GhiChu = "",
                    HoKhau = "Long An",
                    DiaChi = "HCM",
                    HinhAnh = "",
                    MatKhau = "Client@123",
                    MaTrangThaiTaiKhoan = "0",
                    HoTenPhuHuynh = "Lê Huỳnh Nam",
                    NamSinhPhuHuynh = "1968",
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
                });

            modelBuilder.Entity<ThucDon>().HasData(
                new ThucDon() { MaThucDon = 1, NgayApDung = new DateTime(2022, 12, 5), NgayTao = new DateTime(2022, 12, 3), MaDanhMuc = 1 });

            modelBuilder.Entity<MonAn>().HasData(
                new MonAn() { MaMonAn = 1, TenMonAn = "Chôm chôm", GhiChu = "" },
                new MonAn() { MaMonAn = 2, TenMonAn = "Thịt heo nạc xào đậu cô ve", GhiChu = "" });

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
                   MaNhanSu = 1,
                   Ho = "Lê Nguyễn Đại Đức",
                   Ten = "Tâm",
                   MaGioiTinh = "0",
                   NgaySinh = new DateTime(2001, 01, 10),
                   NoiSinh = "Long An",
                   CMND = "123456789",
                   NgayCap = null,
                   MaDanToc = "01",
                   MaTonGiao = "99",
                   MaQuocTich = "704",
                   NgayVaoTruong = new DateTime(2020, 01, 10),
                   MaPhongBan = 1,
                   MaTrangThaiLamViec = "0",
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
                   MaTrangThaiTaiKhoan = "0",
               });

            modelBuilder.Entity<NhanSuPhanQuyen>().HasData(
              new NhanSuPhanQuyen() { MaNhanSu = 1, MaQuyen = 1 });

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