using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.ViewModels.MamNon
{
    public class KhoiLopVm
    {
        public int MaKhoiLop { get; set; }
        public string TenKhoiLop { get; set; }
        public string GhiChu { get; set; }

        public IList<LopHocVm> LopHocVms { get; set; }
    }
}