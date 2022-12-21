using System;
using System.Collections.Generic;
using System.Text;

namespace TruongMamNon.BackendApi.Data.Entities
{
    public class NhanSuPhanQuyen
    {
        public string MaNhanSu { get; set; }
        public int MaQuyen { get; set; }

        public NhanSu NhanSu { get; set; }
        public PhanQuyen PhanQuyen { get; set; }
    }
}