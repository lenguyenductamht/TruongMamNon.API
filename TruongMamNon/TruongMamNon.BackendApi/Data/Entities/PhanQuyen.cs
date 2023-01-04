namespace TruongMamNon.BackendApi.Data.Entities
{
    public class PhanQuyen
    {
        public int MaQuyen { get; set; }
        public string TenQuyen { get; set; }
        public string GhiChu { get; set; }

        public List<NhanSuPhanQuyen> NhanSuPhanQuyens { get; set; }
    }
}