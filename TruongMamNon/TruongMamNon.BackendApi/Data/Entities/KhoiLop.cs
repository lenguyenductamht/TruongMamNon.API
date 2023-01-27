namespace TruongMamNon.BackendApi.Data.Entities
{
    public class KhoiLop
    {
        public int MaKhoiLop { get; set; }
        public string TenKhoiLop { get; set; }
        public string GhiChu { get; set; }

        public virtual List<LopHoc> LopHocs { get; set; }
        public virtual List<HocSinh> HocSinhs { get; set; }
        public virtual List<NhanSu> NhanSus { get; set; }
    }
}