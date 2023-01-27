namespace TruongMamNon.BackendApi.RequestModels
{
    public class AddPhieuNhapThucPhamRequest
    {
        public DateTime NgayNhap { get; set; }
        public string MaNguoiNhap { get; set; }
        public string GhiChu { get; set; }
        public string TrangThai { get; set; }
    }
}