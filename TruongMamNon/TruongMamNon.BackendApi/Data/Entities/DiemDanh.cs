namespace TruongMamNon.BackendApi.Data.Entities
{
    public class DiemDanh
    {
        public long MaDiemDanh { get; set; }
        public DateTime NgayDiemDanh { get; set; }
        public string MaHocSinh { get; set; }
        public string TrangThai { get; set; }

        public HocSinh HocSinh { get; set; }
    }
}