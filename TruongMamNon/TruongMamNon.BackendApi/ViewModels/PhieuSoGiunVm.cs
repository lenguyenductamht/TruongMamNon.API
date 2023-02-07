using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.ViewModels
{
    public class PhieuSoGiunVm
    {
        public long MaPhieuSoGiun { get; set; }
        public int MaDotSoGiun { get; set; }
        public long MaHocSinh { get; set; }
        public string TrangThai { get; set; }

        public DotSoGiun DotSoGiun { get; set; }
        public HocSinh HocSinh { get; set; }
    }
}