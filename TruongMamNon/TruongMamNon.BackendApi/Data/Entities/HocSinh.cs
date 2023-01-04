namespace TruongMamNon.BackendApi.Data.Entities
{
    public class HocSinh
    {
        public int Id { get; set; }
        public string MaHocSinh { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string MaGioiTinh { get; set; }
        public int MaKhoiLop { get; set; }
        public int? MaLopHoc { get; set; }
        public DateTime NgayNhapHoc { get; set; }
        public string MaTrangThaiHoc { get; set; }
        public string LyDoNghiHoc { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public DateTime NgaySinh { get; set; }
        public string NoiSinh { get; set; }
        public string MaDanToc { get; set; }
        public string MaTonGiao { get; set; }
        public string MaQuocTich { get; set; }
        public string GhiChu { get; set; }
        public string HoKhau { get; set; }
        public string DiaChi { get; set; }
        public string HinhAnh { get; set; }

        //Tai Khoan

        public string MatKhau { get; set; }
        public string MaTrangThaiTaiKhoan { get; set; }

        //Phu huynh

        public string HoTenPhuHuynh { get; set; }
        public string NamSinhPhuHuynh { get; set; }
        public string CMNDPhuHuynh { get; set; }
        public string SDTPhuHuynh { get; set; }
        public string NgheNghiepPhuHuynh { get; set; }
        public string EmailPhuHuynh { get; set; }
        public string DiaChiPhuHuynh { get; set; }

        public KhoiLop KhoiLop { get; set; }
        public LopHoc LopHoc { get; set; }
        public GioiTinh GioiTinh { get; set; }
        public DanToc DanToc { get; set; }
        public TonGiao TonGiao { get; set; }
        public QuocGia QuocTich { get; set; }
        public TrangThaiHoc TrangThaiHoc { get; set; }
        public TrangThaiTaiKhoan TrangThaiTaiKhoan { get; set; }

        public List<DiemDanh> DiemDanhs { get; set; }
        public List<KhamSucKhoe> KhamSucKhoes { get; set; }
        public List<PhieuSoGiun> PhieuSoGiuns { get; set; }
        public List<PhieuTiemVaccine> PhieuTiemVaccines { get; set; }
        public List<PhieuUongVitamin> PhieuUongVitamins { get; set; }
    }
}