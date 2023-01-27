namespace TruongMamNon.BackendApi.Data.Entities
{
    public class TrangThaiDiemDanh
    {
        public string MaTrangThai { get; set; }
        public string TenTrangThai { get; set; }

        public virtual List<DiemDanh> DiemDanhs { get; set; }
    }
}