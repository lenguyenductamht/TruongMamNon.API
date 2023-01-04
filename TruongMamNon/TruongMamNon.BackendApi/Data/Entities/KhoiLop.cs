namespace TruongMamNon.BackendApi.Data.Entities
{
    public class KhoiLop
    {
        public int MaKhoiLop { get; set; }
        public string TenKhoiLop { get; set; }
        public string GhiChu { get; set; }

        public List<LopHoc> LopHocs { get; set; }
        public List<HocSinh> HocSinhs { get; set; }
        public List<NhanSu> NhanSus { get; set; }
    }
}