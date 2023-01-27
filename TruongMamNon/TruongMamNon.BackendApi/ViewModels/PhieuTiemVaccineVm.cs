using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.ViewModels
{
    public class PhieuTiemVaccineVm
    {
        public long MaPhieuTiemVaccine { get; set; }
        public int MaDotTiemVaccine { get; set; }
        public string MaHocSinh { get; set; }
        public string TrangThai { get; set; }

        public DotTiemVaccine DotTiemVaccine { get; set; }
        public HocSinh HocSinh { get; set; }
    }
}