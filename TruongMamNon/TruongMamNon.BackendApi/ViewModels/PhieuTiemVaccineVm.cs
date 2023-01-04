using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.ViewModels
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