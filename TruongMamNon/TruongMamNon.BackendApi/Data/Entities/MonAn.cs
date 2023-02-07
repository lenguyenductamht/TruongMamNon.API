namespace TruongMamNon.BackendApi.Data.Entities
{
    public class MonAn
    {
        public int MaMonAn { get; set; }
        public string TenMonAn { get; set; }
        public string GhiChu { get; set; }

        public virtual List<MonAnThucPham> MonAnThucPhams { get; set; }
        public virtual List<ThucDonMonAn> ThucDonMonAns { get; set; }
    }
}