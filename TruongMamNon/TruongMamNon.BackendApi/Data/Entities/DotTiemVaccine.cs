namespace TruongMamNon.BackendApi.Data.Entities
{
    public class DotTiemVaccine
    {
        public int MaDotTiemVaccine { get; set; }
        public string TenDotTiemVaccine { get; set; }
        public DateTimeOffset NgayTiemVaccine { get; set; }
        public int MaVaccine { get; set; }
        public int MaNienHoc { get; set; }

        public Vaccine Vaccine { get; set; }
        public NienHoc NienHoc { get; set; }

        public virtual List<PhieuTiemVaccine> PhieuTiemVaccines { get; set; }
    }
}