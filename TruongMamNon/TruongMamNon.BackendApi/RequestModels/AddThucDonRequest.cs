namespace TruongMamNon.BackendApi.RequestModels
{
    public class AddThucDonRequest
    {
        public DateTime NgayApDung { get; set; }
        public DateTime NgayTao { get; set; }
        public int MaDanhMuc { get; set; }
    }
}