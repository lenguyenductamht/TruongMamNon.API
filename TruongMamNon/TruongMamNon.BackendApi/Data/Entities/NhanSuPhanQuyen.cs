namespace TruongMamNon.BackendApi.Data.Entities
{
    public class NhanSuPhanQuyen
    {
        public long MaNhanSu { get; set; }
        public int MaQuyen { get; set; }

        public NhanSu NhanSu { get; set; }
        public PhanQuyen PhanQuyen { get; set; }
    }
}