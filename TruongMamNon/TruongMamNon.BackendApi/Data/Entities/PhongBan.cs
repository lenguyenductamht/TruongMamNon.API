namespace TruongMamNon.BackendApi.Data.Entities
{
    public class PhongBan
    {
        public int MaPhongBan { get; set; }
        public string TenPhongBan { get; set; }
        public string GhiChu { get; set; }

        public virtual List<NhanSu> NhanSus { get; set; }
    }
}