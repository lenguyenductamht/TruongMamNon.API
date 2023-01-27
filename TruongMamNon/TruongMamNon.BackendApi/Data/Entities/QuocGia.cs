namespace TruongMamNon.BackendApi.Data.Entities
{
    public class QuocGia
    {
        public string MaQuocGia { get; set; }

        public string TenQuocGia { get; set; }

        public virtual List<NhanSu> NhanSus { get; set; }
        public virtual List<HocSinh> HocSinhs { get; set; }
    }
}