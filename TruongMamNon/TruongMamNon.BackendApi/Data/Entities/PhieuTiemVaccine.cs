using System;
using System.Collections.Generic;
using System.Text;

namespace TruongMamNon.BackendApi.Data.Entities
{
    public class PhieuTiemVaccine
    {
        public int MaVaccine { get; set; }
        public string MaHocSinh { get; set; }
        public DateTime NgayTiem { get; set; }

        public Vaccine Vaccine { get; set; }
        public HocSinh HocSinh { get; set; }
    }
}