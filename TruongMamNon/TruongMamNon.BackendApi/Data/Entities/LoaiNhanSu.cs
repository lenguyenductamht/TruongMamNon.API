namespace TruongMamNon.BackendApi.Data.Entities
{
    public class LoaiNhanSu
    {
        public int MaLoaiNhanSu { get; set; }
        public string TenLoaiNhanSu { get; set; }
        public string GhiChu { get; set; }

        public virtual List<ChucVu> ChucVus { get; set; }
        public virtual List<NhanSu> NhanSus { get; set; }
    }
}