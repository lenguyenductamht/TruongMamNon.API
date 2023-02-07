namespace TruongMamNon.BackendApi.RequestModels
{
    public class AddNhanSuRequest
    {
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

        //Tai Khoan

        public string MatKhau { get; set; }
        public string MaTrangThaiTaiKhoan { get; set; }
    }
}