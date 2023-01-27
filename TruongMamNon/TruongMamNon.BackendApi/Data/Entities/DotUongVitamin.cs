namespace TruongMamNon.BackendApi.Data.Entities
{
    public class DotUongVitamin
    {
        public int MaDotUongVitamin { get; set; }
        public string TenDotUongVitamin { get; set; }
        public DateTimeOffset NgayUongVitamin { get; set; }
        public int MaVitamin { get; set; }
        public int MaNienHoc { get; set; }

        public Vitamin Vitamin { get; set; }
        public NienHoc NienHoc { get; set; }

        public List<PhieuUongVitamin> PhieuUongVitamins { get; set; }
    }
}