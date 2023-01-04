namespace TruongMamNon.BackendApi.RequestModels
{
    public class AUNienHocRequest
    {
        public string TenNienHoc { get; set; }
        public DateTimeOffset BatDauHK1 { get; set; }
        public DateTimeOffset KetThucHK1 { get; set; }
        public DateTimeOffset BatDauHK2 { get; set; }
        public DateTimeOffset KetThucHK2 { get; set; }
    }
}