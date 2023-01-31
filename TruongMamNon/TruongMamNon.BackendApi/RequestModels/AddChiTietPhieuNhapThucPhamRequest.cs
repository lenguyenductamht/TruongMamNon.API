namespace TruongMamNon.BackendApi.RequestModels
{
    public class AddChiTietPhieuNhapThucPhamRequest
    {
        public long MaPhieuNhapThucPham { get; set; }
        public int MaThucPham { get; set; }
        public decimal DonGia { get; set; }
        public double SoLuong { get; set; }
    }
}