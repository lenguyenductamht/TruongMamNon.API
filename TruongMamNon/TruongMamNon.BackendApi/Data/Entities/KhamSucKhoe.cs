namespace TruongMamNon.BackendApi.Data.Entities
{
    public class KhamSucKhoe
    {
        public long MaKhamSucKhoe { get; set; }
        public string TenDotKham { get; set; }
        public DateTime NgayKham { get; set; }
        public string KetLuan { get; set; }
        public string MaHocSinh { get; set; }

        //The Chat

        public int ChieuCao { get; set; }
        public int CanNang { get; set; }
        public double BMI { get; set; }
        public int NhipTim { get; set; }
        public int TamThu { get; set; }
        public int TamTruong { get; set; }
        public string LoaiTheLuc { get; set; }

        //Nhi Khoa

        public string TuanHoan { get; set; }
        public string HoHap { get; set; }
        public string TieuHoa { get; set; }
        public string ThanTietNieu { get; set; }
        public string ThanKinhTamThan { get; set; }
        public string LamSangKhac { get; set; }

        //Mat

        public int MatPhaiKhongKinh { get; set; }
        public int MatTraiKhongKinh { get; set; }
        public int MatPhaiCoKinh { get; set; }
        public int MatTraiCoKinh { get; set; }
        public string CacBenhVeMat { get; set; }

        //Tai Mui Hong

        public int TaiTraiNoiThuong { get; set; }
        public int TaiTraiNoiTham { get; set; }
        public int TaiPhaiNoiThuong { get; set; }
        public int TaiPhaiNoiTham { get; set; }
        public string CacBenhTaiMuiHong { get; set; }

        //Rang Ham Mat

        public string HamTren { get; set; }
        public string HamDuoi { get; set; }
        public string CacBenhRangHamMat { get; set; }

        public HocSinh HocSinh { get; set; }
    }
}