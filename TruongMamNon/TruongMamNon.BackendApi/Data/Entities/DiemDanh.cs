namespace TruongMamNon.BackendApi.Data.Entities
{
    public class DiemDanh
    {
        public long MaDiemDanh { get; set; }
        public DateTime NgayDiemDanh { get; set; }
        public long MaHocSinh { get; set; }
        public string MaTrangThaiDiemDanh { get; set; }

        public HocSinh HocSinh { get; set; }
        public TrangThaiDiemDanh TrangThaiDiemDanh { get; set; }
    }
}