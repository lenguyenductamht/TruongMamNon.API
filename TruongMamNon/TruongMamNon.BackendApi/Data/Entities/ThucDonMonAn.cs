using System;
using System.Collections.Generic;
using System.Text;

namespace TruongMamNon.BackendApi.Data.Entities
{
    public class ThucDonMonAn
    {
        public int MaThucDon { get; set; }
        public int MaMonAn { get; set; }
        public int SoLuong { get; set; }

        public ThucDon ThucDon { get; set; }
        public MonAn MonAn { get; set; }
    }
}