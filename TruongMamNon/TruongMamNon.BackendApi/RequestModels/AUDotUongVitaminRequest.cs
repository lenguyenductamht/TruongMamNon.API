namespace TruongMamNon.BackendApi.RequestModels
{
    public class AUDotUongVitaminRequest
    {
        public string TenDotUongVitamin { get; set; }
        public DateTimeOffset NgayUongVitamin { get; set; }
        public int MaVitamin { get; set; }
        public int MaNienHoc { get; set; }
    }
}