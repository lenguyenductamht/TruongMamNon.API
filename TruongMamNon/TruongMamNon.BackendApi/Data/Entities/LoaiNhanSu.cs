namespace TruongMamNon.BackendApi.Data.Entities
{
    public class LoaiNhanSu
    {
        public int MaLoaiNhanSu { get; set; }
        public string TenLoaiNhanSu { get; set; }
        public string GhiChu { get; set; }

        public List<ChucVu> ChucVus { get; set; }
        public List<NhanSu> NhanSus { get; set; }
    }
}