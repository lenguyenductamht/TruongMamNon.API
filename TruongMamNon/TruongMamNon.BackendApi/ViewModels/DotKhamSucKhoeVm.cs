using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.ViewModels
{
    public class DotKhamSucKhoeVm
    {
        public int MaDotKhamSucKhoe { get; set; }
        public string TenDotKhamSucKhoe { get; set; }
        public DateTimeOffset NgayKhamSucKhoe { get; set; }
        public int MaNienHoc { get; set; }

        public NienHoc NienHoc { get; set; }
    }
}