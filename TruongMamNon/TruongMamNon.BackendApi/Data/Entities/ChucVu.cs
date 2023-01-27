namespace TruongMamNon.BackendApi.Data.Entities
{
    public class ChucVu
    {
        public int MaChucVu { get; set; }
        public string TenChucVu { get; set; }
        public string GhiChu { get; set; }
        public int MaLoaiNhanSu { get; set; }

        public LoaiNhanSu LoaiNhanSu { get; set; }

        public virtual List<NhanSu> NhanSus { get; set; }
    }
}