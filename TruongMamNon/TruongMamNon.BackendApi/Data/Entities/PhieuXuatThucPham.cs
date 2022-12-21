namespace TruongMamNon.BackendApi.Data.Entities
{
    public class PhieuXuatThucPham
    {
        public long MaPhieuXuatThucPham { get; set; }
        public DateTime NgayXuat { get; set; }
        public string MaNguoiXuat { get; set; }
        public string GhiChu { get; set; }
        public string TrangThai { get; set; }

        public NhanSu NguoiXuat { get; set; }

        public List<ChiTietPhieuNhapThucPham> ChiTietPhieuNhapThucPhams { get; set; }
        public List<ChiTietPhieuXuatThucPham> ChiTietPhieuXuatThucPhams { get; set; }
    }
}