namespace TruongMamNon.BackendApi.Data.Entities
{
    public class ThucDon
    {
        public int MaThucDon { get; set; }
        public DateTime NgayApDung { get; set; }
        public DateTime NgayTao { get; set; }
        public int MaDanhMuc { get; set; }

        public DanhMucThucDon DanhMucThucDon { get; set; }

        public virtual List<ThucDonMonAn> ThucDonMonAns { get; set; }
    }
}