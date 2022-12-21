using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.ViewModels.YTeHocDuong
{
    public class PhieuTiemVaccineVm
    {
        public int MaVaccine { get; set; }
        public string MaHocSinh { get; set; }
        public DateTime NgayTiem { get; set; }

        public Vaccine Vaccine { get; set; }
        public HocSinh HocSinh { get; set; }
    }
}