namespace TruongMamNon.BackendApi.RequestModels
{
    public class AUDotTiemVaccineRequest
    {
        public string TenDotTiemVaccine { get; set; }
        public DateTimeOffset NgayTiemVaccine { get; set; }
        public int MaVaccine { get; set; }
        public int MaNienHoc { get; set; }
    }
}