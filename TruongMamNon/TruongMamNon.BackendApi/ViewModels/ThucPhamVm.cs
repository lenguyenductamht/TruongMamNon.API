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

        //Dinh dưỡng

        public double NangLuong { get; set; }
        public double ChatDam { get; set; }
        public double ChatBeo { get; set; }
        public double ChatBot { get; set; }

        public DanhMucThucPham DanhMucThucPham { get; set; }
    }
}