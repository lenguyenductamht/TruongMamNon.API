namespace TruongMamNon.BackendApi.Data.Entities
{
    public class TrangThaiLamViec
    {
        public string MaTrangThai { get; set; }
        public string TenTrangThai { get; set; }

        public virtual List<NhanSu> NhanSus { get; set; }
    }
}