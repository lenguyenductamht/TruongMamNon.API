using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.ViewModels
{
    public class ThucPhamVm
    {
        public int MaThucPham { get; set; }
        public string TenThucPham { get; set; }
        public string DonViTinh { get; set; }
        public double TonKho { get; set; }
        public int MaDanhMuc { get; set; }

        public DanhMucThucPham DanhMucThucPham { get; set; }
    }
}