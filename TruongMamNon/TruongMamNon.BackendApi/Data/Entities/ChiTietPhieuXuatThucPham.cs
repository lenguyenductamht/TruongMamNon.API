namespace TruongMamNon.BackendApi.Data.Entities
{
    public class ChiTietPhieuXuatThucPham
    {
        public long MaPhieuXuatThucPham { get; set; }
        public int MaThucPham { get; set; }
        public double SoLuong { get; set; }

        public ThucPham ThucPham { get; set; }
        public PhieuXuatThucPham PhieuXuatThucPham { get; set; }
    }
}