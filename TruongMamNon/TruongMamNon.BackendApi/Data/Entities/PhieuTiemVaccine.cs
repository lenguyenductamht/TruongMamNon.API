namespace TruongMamNon.BackendApi.Data.Entities
{
    public class PhieuTiemVaccine
    {
        public long MaPhieuTiemVaccine { get; set; }
        public int MaDotTiemVaccine { get; set; }
        public long MaHocSinh { get; set; }
        public string TrangThai { get; set; }

        public DotTiemVaccine DotTiemVaccine { get; set; }
        public HocSinh HocSinh { get; set; }
    }
}