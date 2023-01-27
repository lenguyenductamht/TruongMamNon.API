using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.ViewModels
{
    public class PhieuNhapThucPhamVm
    {
        public long MaPhieuNhapThucPham { get; set; }
        public DateTime NgayNhap { get; set; }
        public string MaNguoiNhap { get; set; }
        public string GhiChu { get; set; }
        public string TrangThai { get; set; }

        public NhanSu NguoiNhap { get; set; }
    }
}