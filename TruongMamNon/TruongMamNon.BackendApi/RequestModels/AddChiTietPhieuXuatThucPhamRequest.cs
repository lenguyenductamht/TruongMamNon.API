namespace TruongMamNon.BackendApi.RequestModels
{
    public class AddChiTietPhieuXuatThucPhamRequest
    {
        public long MaPhieuXuatThucPham { get; set; }
        public int MaThucPham { get; set; }
        public decimal DonGia { get; set; }
        public double SoLuong { get; set; }
    }
}