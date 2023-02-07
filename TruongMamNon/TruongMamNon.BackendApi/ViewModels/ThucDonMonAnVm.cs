using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.ViewModels
{
    public class ThucDonMonAnVm
    {
        public int MaThucDon { get; set; }
        public int MaMonAn { get; set; }
        public int SoLuong { get; set; }

        public ThucDon ThucDon { get; set; }
        public MonAn MonAn { get; set; }
    }
}