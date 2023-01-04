namespace TruongMamNon.BackendApi.Data.Entities
{
    public class GiaoVienChuNhiem
    {
        public string MaNhanSu { get; set; }
        public int MaLopHoc { get; set; }

        public NhanSu NhanSu { get; set; }
        public LopHoc LopHoc { get; set; }
    }
}