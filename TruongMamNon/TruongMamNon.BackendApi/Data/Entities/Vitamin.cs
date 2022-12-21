namespace TruongMamNon.BackendApi.Data.Entities
{
    public class Vitamin
    {
        public int MaVitamin { get; set; }
        public string TenVitamin { get; set; }
        public string GhiChu { get; set; }

        public List<PhieuUongVitamin> PhieuUongVitamins { get; set; }
    }
}