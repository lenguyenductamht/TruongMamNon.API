using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.ViewModels.TruongHoc
{
    public class ChucVuVm
    {
        public int MaChucVu { get; set; }
        public string TenChucVu { get; set; }
        public string GhiChu { get; set; }

        public LoaiNhanSu LoaiNhanSu { get; set; }
    }
}