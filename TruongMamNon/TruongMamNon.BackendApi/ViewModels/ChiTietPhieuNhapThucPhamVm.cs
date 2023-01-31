using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.ViewModels
{
    public class ChiTietPhieuNhapThucPhamVm
    {
        public long MaPhieuNhapThucPham { get; set; }
        public int MaThucPham { get; set; }
        public decimal DonGia { get; set; }
        public double SoLuong { get; set; }

        public ThucPham ThucPham { get; set; }
        public PhieuNhapThucPham PhieuNhapThucPham { get; set; }
    }
}