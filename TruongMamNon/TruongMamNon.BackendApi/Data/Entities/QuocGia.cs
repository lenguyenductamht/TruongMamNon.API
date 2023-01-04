namespace TruongMamNon.BackendApi.Data.Entities
{
    public class QuocGia
    {
        public string MaQuocGia { get; set; }

        public string TenQuocGia { get; set; }

        public List<NhanSu> NhanSus { get; set; }
        public List<HocSinh> HocSinhs { get; set; }
    }
}