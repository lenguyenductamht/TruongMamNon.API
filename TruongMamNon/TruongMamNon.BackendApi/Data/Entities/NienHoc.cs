using System;
using System.Collections.Generic;
using System.Text;
using TruongMamNon.BackendApi.Data.EF;

namespace TruongMamNon.BackendApi.Data.Entities
{
    public class NienHoc
    {
        public int MaNienHoc { get; set; }
        public string TenNienHoc { get; set; }
        public DateTime BatDauHK1 { get; set; }
        public DateTime KetThucHK1 { get; set; }
        public DateTime BatDauHK2 { get; set; }
        public DateTime KetThucHK2 { get; set; }

        public List<LopHoc> LopHocs { get; set; }
    }
}