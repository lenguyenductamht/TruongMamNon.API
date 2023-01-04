namespace TruongMamNon.BackendApi.RequestModels
{
    public class AULopHocRequest
    {
        public string TenLop { get; set; }
        public int MaKhoiLop { get; set; }
        public decimal HocPhi { get; set; }
        public int SiSoToiDa { get; set; }
        public int MaNienHoc { get; set; }
    }
}