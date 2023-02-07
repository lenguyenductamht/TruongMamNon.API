namespace TruongMamNon.BackendApi.Data.Entities
{
    public class NhanSu
    {
        public long MaNhanSu { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string MaGioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string NoiSinh { get; set; }
        public string CMND { get; set; }
        public DateTime? NgayCap { get; set; }
        public string MaDanToc { get; set; }
        public string MaTonGiao { get; set; }
        public string MaQuocTich { get; set; }
        public DateTime NgayVaoTruong { get; set; }
        public int MaPhongBan { get; set; }
        public string MaTrangThaiLamViec { get; set; }
        public string LyDoThoiViec { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public int MaLoaiNhanSu { get; set; }
        public int? MaChucVu { get; set; }
        public int? MaKhoiLop { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string HoKhau { get; set; }
        public string DiaChi { get; set; }
        public string HinhAnh { get; set; }

        //Tai Khoan

        public string MatKhau { get; set; }
        public string MaTrangThaiTaiKhoan { get; set; }

        public PhongBan PhongBan { get; set; }
        public LoaiNhanSu LoaiNhanSu { get; set; }
        public ChucVu ChucVu { get; set; }
        public KhoiLop KhoiLop { get; set; }

        public GioiTinh GioiTinh { get; set; }
        public DanToc DanToc { get; set; }
        public TonGiao TonGiao { get; set; }
        public QuocGia QuocTich { get; set; }
        public TrangThaiLamViec TrangThaiLamViec { get; set; }
        public TrangThaiTaiKhoan TrangThaiTaiKhoan { get; set; }

        public virtual List<NhanSuPhanQuyen> NhanSuPhanQuyens { get; set; }
        public virtual List<PhieuNhapThucPham> PhieuNhapThucPhams { get; set; }
        public virtual List<PhieuXuatThucPham> PhieuXuatThucPhams { get; set; }
        public virtual List<GiaoVienChuNhiem> GiaoVienChuNhiems { get; set; }
    }
}