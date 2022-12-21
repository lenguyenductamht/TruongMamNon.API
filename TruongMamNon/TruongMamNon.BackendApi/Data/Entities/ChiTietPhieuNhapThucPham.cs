using System;
using System.Collections.Generic;
using System.Text;

namespace TruongMamNon.BackendApi.Data.Entities
{
    public class ChiTietPhieuNhapThucPham
    {
        public long MaPhieuNhapThucPham { get; set; }
        public int MaThucPham { get; set; }
        public decimal DonGia { get; set; }
        public double SoLuong { get; set; }

        public ThucPham ThucPham { get; set; }
        public PhieuNhapThucPham PhieuNhapThucPham { get; set; }
    }
}