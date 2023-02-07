namespace TruongMamNon.BackendApi.RequestModels
{
    public class AUDotKhamSucKhoeRequest
    {
        public string TenDotKhamSucKhoe { get; set; }
        public DateTimeOffset NgayKhamSucKhoe { get; set; }
        public int MaNienHoc { get; set; }
    }
}