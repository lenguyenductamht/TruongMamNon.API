namespace TruongMamNon.BackendApi.Data.Entities
{
    public class MonAnThucPham
    {
        public int MaMonAn { get; set; }
        public int MaThucPham { get; set; }
        public double SoLuong { get; set; }

        public MonAn MonAn { get; set; }
        public ThucPham ThucPham { get; set; }
    }
}