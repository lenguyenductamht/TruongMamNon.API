namespace TruongMamNon.BackendApi.RequestModels
{
    public class AUDotSoGiunRequest
    {
        public string TenDotSoGiun { get; set; }
        public DateTimeOffset NgaySoGiun { get; set; }
        public int MaThuocSoGiun { get; set; }
        public int MaNienHoc { get; set; }
    }
}