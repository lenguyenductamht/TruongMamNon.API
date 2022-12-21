using System;
using System.Collections.Generic;
using System.Text;

namespace TruongMamNon.BackendApi.Data.Entities
{
    public class DanhMucThucPham
    {
        public int MaDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }
        public string GhiChu { get; set; }

        public List<ThucPham> ThucPhams { get; set; }
    }
}