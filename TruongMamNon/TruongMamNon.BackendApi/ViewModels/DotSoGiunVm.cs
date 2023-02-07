using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.ViewModels
{
    public class DotSoGiunVm
    {
        public int MaDotSoGiun { get; set; }
        public string TenDotSoGiun { get; set; }
        public DateTimeOffset NgaySoGiun { get; set; }
        public int MaThuocSoGiun { get; set; }
        public int MaNienHoc { get; set; }

        public ThuocSoGiun ThuocSoGiun { get; set; }
        public NienHoc NienHoc { get; set; }
    }
}