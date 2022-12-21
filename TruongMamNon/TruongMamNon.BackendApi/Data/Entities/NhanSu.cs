using System;
using System.Collections.Generic;
using System.Text;

namespace TruongMamNon.BackendApi.Data.Entities
{
    public class NhanSu
    {
        public int Id { get; set; }
        public string MaNhanSu { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string NoiSinh { get; set; }
        public string CMND { get; set; }
        public DateTime? NgayCap { get; set; }
        public string DanToc { get; set; }
        public string TonGiao { get; set; }
        public string QuocTich { get; set; }
        public DateTime NgayVaoTruong { get; set; }
        public int MaPhongBan { get; set; }
        public string TrangThaiLamViec { get; set; }
        public string LyDoThoiViec { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public int MaLoaiNhanSu { get; set; }
        public int? MaChucVu { get; set; }
        public int? MaKhoiLop { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string HoKhau { get; set; }
        public string DiaChi { get; set; }
        public string HinhAnh { get; set; }

        //Tai Khoan

        public string MatKhau { get; set; }
        public string TrangThaiTaiKhoan { get; set; }

        public PhongBan PhongBan { get; set; }
        public LoaiNhanSu LoaiNhanSu { get; set; }
        public ChucVu ChucVu { get; set; }
        public KhoiLop KhoiLop { get; set; }

        public List<NhanSuPhanQuyen> NhanSuPhanQuyens { get; set; }
        public List<PhieuNhapThucPham> PhieuNhapThucPhams { get; set; }
        public List<PhieuXuatThucPham> PhieuXuatThucPhams { get; set; }
        public List<GiaoVienChuNhiem> GiaoVienChuNhiems { get; set; }
    }
}