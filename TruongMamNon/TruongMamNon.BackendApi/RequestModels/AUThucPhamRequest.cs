namespace TruongMamNon.BackendApi.RequestModels
{
    public class AUThucPhamRequest
    {
        public string TenThucPham { get; set; }
        public string DonViTinh { get; set; }
        public double TonKho { get; set; }
        public int MaDanhMuc { get; set; }
    }
}