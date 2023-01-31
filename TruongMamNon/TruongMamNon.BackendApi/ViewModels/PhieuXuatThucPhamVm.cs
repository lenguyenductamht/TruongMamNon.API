using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.ViewModels
{
    public class PhieuXuatThucPhamVm
    {
        public long MaPhieuXuatThucPham { get; set; }
        public DateTime NgayXuat { get; set; }
        public string MaNguoiXuat { get; set; }
        public string GhiChu { get; set; }
        public string TrangThai { get; set; }

        public NhanSu NguoiXuat { get; set; }
    }
}