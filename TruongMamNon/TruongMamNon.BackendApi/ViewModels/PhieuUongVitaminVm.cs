using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.ViewModels
{
    public class PhieuUongVitaminVm
    {
        public long MaPhieuUongVitamin { get; set; }
        public int MaDotUongVitamin { get; set; }
        public long MaHocSinh { get; set; }
        public string TrangThai { get; set; }

        public DotUongVitamin DotUongVitamin { get; set; }
        public HocSinh HocSinh { get; set; }
    }
}