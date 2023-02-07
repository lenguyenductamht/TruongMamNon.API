namespace TruongMamNon.BackendApi.Data.Entities
{
    public class DotKhamSucKhoe
    {
        public int MaDotKhamSucKhoe { get; set; }
        public string TenDotKhamSucKhoe { get; set; }
        public DateTimeOffset NgayKhamSucKhoe { get; set; }
        public int MaNienHoc { get; set; }

        public NienHoc NienHoc { get; set; }

        public virtual List<PhieuKhamSucKhoe> PhieuKhamSucKhoes { get; set; }
    }
}