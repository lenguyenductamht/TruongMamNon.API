namespace TruongMamNon.BackendApi.Data.Entities
{
    public class TonGiao
    {
        public string MaTonGiao { get; set; }
        public string TenTonGiao { get; set; }

        public virtual List<NhanSu> NhanSus { get; set; }
        public virtual List<HocSinh> HocSinhs { get; set; }
    }
}