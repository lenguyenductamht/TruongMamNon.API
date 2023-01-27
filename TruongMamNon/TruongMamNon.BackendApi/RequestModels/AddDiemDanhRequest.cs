namespace TruongMamNon.BackendApi.RequestModels
{
    public class AddDiemDanhRequest
    {
        public DateTime NgayDiemDanh { get; set; }
        public string MaHocSinh { get; set; }
        public string MaTrangThaiDiemDanh { get; set; }
    }
}