using System;
using System.Collections.Generic;
using System.Text;

namespace TruongMamNon.BackendApi.Data.Entities
{
    public class PhieuNhapThucPham
    {
        public long MaPhieuNhapThucPham { get; set; }
        public DateTime NgayNhap { get; set; }
        public string MaNguoiNhap { get; set; }
        public string GhiChu { get; set; }
        public string TrangThai { get; set; }

        public NhanSu NguoiNhap { get; set; }

        public List<ChiTietPhieuNhapThucPham> ChiTietPhieuNhapThucPhams { get; set; }
    }
}