namespace TruongMamNon.BackendApi.Data.Entities
{
    public class Vaccine
    {
        public int MaVaccine { get; set; }
        public string TenVaccine { get; set; }
        public string GhiChu { get; set; }

        public List<DotTiemVaccine> DotTiemVaccines { get; set; }
    }
}