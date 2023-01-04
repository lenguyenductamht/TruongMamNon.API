namespace TruongMamNon.BackendApi.Data.Entities
{
    public class ThuocSoGiun
    {
        public int MaThuocSoGiun { get; set; }
        public string TenThuocSoGiun { get; set; }
        public string GhiChu { get; set; }

        public List<DotSoGiun> DotSoGiuns { get; set; }
    }
}