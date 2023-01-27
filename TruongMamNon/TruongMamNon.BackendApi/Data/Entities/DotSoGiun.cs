namespace TruongMamNon.BackendApi.Data.Entities
{
    public class DotSoGiun
    {
        public int MaDotSoGiun { get; set; }
        public string TenDotSoGiun { get; set; }
        public DateTimeOffset NgaySoGiun { get; set; }
        public int MaThuocSoGiun { get; set; }
        public int MaNienHoc { get; set; }

        public ThuocSoGiun ThuocSoGiun { get; set; }
        public NienHoc NienHoc { get; set; }

        public virtual List<PhieuSoGiun> PhieuSoGiuns { get; set; }
    }
}