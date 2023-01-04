namespace TruongMamNon.BackendApi.Data.Entities
{
    public class TonGiao
    {
        public string MaTonGiao { get; set; }
        public string TenTonGiao { get; set; }

        public List<NhanSu> NhanSus { get; set; }
        public List<HocSinh> HocSinhs { get; set; }
    }
}