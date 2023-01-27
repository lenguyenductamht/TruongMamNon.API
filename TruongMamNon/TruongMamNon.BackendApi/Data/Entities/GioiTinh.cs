namespace TruongMamNon.BackendApi.Data.Entities
{
    public class GioiTinh
    {
        public string MaGioiTinh { get; set; }
        public string TenGioiTinh { set; get; }

        public virtual List<NhanSu> NhanSus { get; set; }
        public virtual List<HocSinh> HocSinhs { get; set; }
    }
}