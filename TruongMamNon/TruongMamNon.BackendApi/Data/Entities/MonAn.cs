namespace TruongMamNon.BackendApi.Data.Entities
{
    public class MonAn
    {
        public int MaMonAn { get; set; }
        public string TenMonAn { get; set; }
        public string GhiChu { get; set; }

        public double NangLuong { get; set; }
        public double ChatDam { get; set; }
        public double ChatBeo { get; set; }
        public double ChatBot { get; set; }

        public List<MonAnThucPham> MonAnThucPhams { get; set; }
        public List<ThucDonMonAn> ThucDonMonAns { get; set; }
    }
}