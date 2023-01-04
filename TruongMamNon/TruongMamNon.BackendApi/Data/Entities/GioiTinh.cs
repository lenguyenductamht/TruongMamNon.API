namespace TruongMamNon.BackendApi.Data.Entities
{
    public class GioiTinh
    {
        public string MaGioiTinh { get; set; }
        public string TenGioiTinh { set; get; }

        public List<NhanSu> NhanSus { get; set; }
        public List<HocSinh> HocSinhs { get; set; }
    }
}