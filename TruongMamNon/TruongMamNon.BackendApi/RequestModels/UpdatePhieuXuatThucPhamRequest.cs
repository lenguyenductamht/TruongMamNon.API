namespace TruongMamNon.BackendApi.RequestModels
{
    public class UpdatePhieuXuatThucPhamRequest
    {
        public DateTime NgayXuat { get; set; }
        public string MaNguoiXuat { get; set; }
        public string GhiChu { get; set; }
        public string TrangThai { get; set; }
    }
}