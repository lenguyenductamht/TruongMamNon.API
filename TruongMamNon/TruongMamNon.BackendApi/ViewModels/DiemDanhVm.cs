using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.ViewModels
{
    public class DiemDanhVm
    {
        public long MaDiemDanh { get; set; }
        public DateTime NgayDiemDanh { get; set; }
        public string MaHocSinh { get; set; }
        public string MaTrangThaiDiemDanh { get; set; }

        public HocSinh HocSinh { get; set; }
        public TrangThaiDiemDanh TrangThaiDiemDanh { get; set; }
    }
}