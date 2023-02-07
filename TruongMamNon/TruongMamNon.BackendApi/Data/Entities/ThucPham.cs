namespace TruongMamNon.BackendApi.Data.Entities
{
    public class ThucPham
    {
        public int MaThucPham { get; set; }
        public string TenThucPham { get; set; }
        public string DonViTinh { get; set; }
        public double TonKho { get; set; }
        public int MaDanhMuc { get; set; }

        public DanhMucThucPham DanhMucThucPham { get; set; }

        public virtual List<ChiTietPhieuNhapThucPham> ChiTietPhieuNhapThucPhams { get; set; }
        public virtual List<ChiTietPhieuXuatThucPham> ChiTietPhieuXuatThucPhams { get; set; }
        public virtual List<MonAnThucPham> MonAnThucPhams { get; set; }
    }
}