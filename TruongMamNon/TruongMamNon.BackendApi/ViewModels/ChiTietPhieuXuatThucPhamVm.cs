using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.ViewModels
{
    public class ChiTietPhieuXuatThucPhamVm
    {
        public long MaPhieuXuatThucPham { get; set; }
        public int MaThucPham { get; set; }
        public decimal DonGia { get; set; }
        public double SoLuong { get; set; }

        public ThucPham ThucPham { get; set; }
        public PhieuXuatThucPham PhieuXuatThucPham { get; set; }
    }
}