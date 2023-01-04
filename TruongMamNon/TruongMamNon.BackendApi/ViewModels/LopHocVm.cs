using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.ViewModels
{
    public class LopHocVm
    {
        public int MaLop { get; set; }
        public string TenLop { get; set; }
        public int MaKhoiLop { get; set; }
        public decimal HocPhi { get; set; }
        public int SiSoToiDa { get; set; }
        public int MaNienHoc { get; set; }

        public KhoiLop? KhoiLop { get; set; }
        public NienHoc? NienHoc { get; set; }
    }
}