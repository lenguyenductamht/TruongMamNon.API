namespace TruongMamNon.BackendApi.Data.Entities
{
    public class NienHoc
    {
        public int MaNienHoc { get; set; }
        public string TenNienHoc { get; set; }
        public DateTimeOffset BatDauHK1 { get; set; }
        public DateTimeOffset KetThucHK1 { get; set; }
        public DateTimeOffset BatDauHK2 { get; set; }
        public DateTimeOffset KetThucHK2 { get; set; }

        public virtual List<LopHoc> LopHocs { get; set; }
        public virtual List<DotSoGiun> DotSoGiuns { get; set; }
        public virtual List<DotTiemVaccine> DotTiemVaccines { get; set; }
        public virtual List<DotUongVitamin> DotUongVitamins { get; set; }
    }
}