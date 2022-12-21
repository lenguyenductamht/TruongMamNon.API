using System;
using System.Collections.Generic;
using System.Text;

namespace TruongMamNon.BackendApi.Data.Entities
{
    public class PhieuUongVitamin
    {
        public int MaVitamin { get; set; }
        public DateTime NgayUong { get; set; }
        public string MaHocSinh { get; set; }

        public HocSinh HocSinh { get; set; }
        public Vitamin Vitamin { get; set; }
    }
}