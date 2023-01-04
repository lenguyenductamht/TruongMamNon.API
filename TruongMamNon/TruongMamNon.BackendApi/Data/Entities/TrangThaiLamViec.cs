namespace TruongMamNon.BackendApi.Data.Entities
{
    public class TrangThaiLamViec
    {
        public string MaTrangThai { get; set; }
        public string TenTrangThai { get; set; }

        public List<NhanSu> NhanSus { get; set; }
    }
}