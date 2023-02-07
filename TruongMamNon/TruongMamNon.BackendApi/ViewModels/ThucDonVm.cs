using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.ViewModels
{
    public class ThucDonVm
    {
        public int MaThucDon { get; set; }
        public DateTime NgayApDung { get; set; }
        public DateTime NgayTao { get; set; }
        public int MaDanhMuc { get; set; }

        public DanhMucThucDon DanhMucThucDon { get; set; }
    }
}