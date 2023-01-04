namespace TruongMamNon.BackendApi.Data.Entities
{
    public class TrangThaiTaiKhoan
    {
        public string MaTrangThai { get; set; }
        public string TenTrangThai { get; set; }

        public List<HocSinh> HocSinhs { get; set; }
        public List<NhanSu> NhanSus { get; set; }
    }
}