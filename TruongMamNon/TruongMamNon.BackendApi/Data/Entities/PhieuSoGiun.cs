using System;
using System.Collections.Generic;
using System.Text;

namespace TruongMamNon.BackendApi.Data.Entities
{
    public class PhieuSoGiun
    {
        public int MaThuocSoGiun { get; set; }
        public DateTime NgaySoGiun { get; set; }
        public string MaHocSinh { get; set; }

        public HocSinh HocSinh { get; set; }
        public ThuocSoGiun ThuocSoGiun { get; set; }
    }
}