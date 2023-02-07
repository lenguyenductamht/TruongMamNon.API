using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.ViewModels
{
    public class DotUongVitaminVm
    {
        public int MaDotUongVitamin { get; set; }
        public string TenDotUongVitamin { get; set; }
        public DateTimeOffset NgayUongVitamin { get; set; }
        public int MaVitamin { get; set; }
        public int MaNienHoc { get; set; }

        public Vitamin Vitamin { get; set; }
        public NienHoc NienHoc { get; set; }
    }
}