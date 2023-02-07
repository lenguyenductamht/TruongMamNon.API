namespace TruongMamNon.BackendApi.Data.Entities
{
    public class DanhMucThucDon
    {
        public int MaDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }
        public string GhiChu { get; set; }
        public string ThoiGian { get; set; }

        public virtual List<ThucDon> ThucDons { get; set; }
    }
}