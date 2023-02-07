using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.ViewModels
{
    public class MonAnThucPhamVm
    {
        public int MaMonAn { get; set; }
        public int MaThucPham { get; set; }
        public double SoLuong { get; set; }

        public MonAn MonAn { get; set; }
        public ThucPham ThucPham { get; set; }
    }
}