using Newtonsoft.Json;

namespace TruongMamNon.BackendApi.Data.Entities
{
    public class GioiTinh
    {
        public string MaGioiTinh { get; set; }
        public string TenGioiTinh { set; get; }

        [JsonIgnore]
        public virtual List<NhanSu> NhanSus { get; set; }
        [JsonIgnore]
        public virtual List<HocSinh> HocSinhs { get; set; }
    }
}