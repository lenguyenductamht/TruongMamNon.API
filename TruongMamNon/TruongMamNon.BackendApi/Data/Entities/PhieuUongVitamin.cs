namespace TruongMamNon.BackendApi.Data.Entities
{
    public class PhieuUongVitamin
    {
        public long MaPhieuUongVitamin { get; set; }
        public int MaDotUongVitamin { get; set; }
        public long MaHocSinh { get; set; }
        public string TrangThai { get; set; }

        public DotUongVitamin DotUongVitamin { get; set; }
        public HocSinh HocSinh { get; set; }
    }
}