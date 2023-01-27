namespace TruongMamNon.BackendApi.Data.Entities
{
    public class DanToc
    {
        public string MaDanToc { get; set; }
        public string TenDanToc { get; set; }

        public virtual List<NhanSu> NhanSus { get; set; }
        public virtual List<HocSinh> HocSinhs { get; set; }
    }
}