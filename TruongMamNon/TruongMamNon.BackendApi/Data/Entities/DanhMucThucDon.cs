namespace TruongMamNon.BackendApi.Data.Entities
{
    public class DanhMucThucDon
    {
        public int MaDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }
        public string GhiChu { get; set; }

        public string ThoiGian { get; set; }

        public double NangLuong { get; set; }
        public double ChatDam { get; set; }
        public double ChatBeo { get; set; }
        public double ChatBot { get; set; }

        public virtual List<ThucDon> ThucDons { get; set; }
    }
}