using Newtonsoft.Json;

namespace TruongMamNon.BackendApi.Data.Entities
{
    public class DanToc
    {
        public string MaDanToc { get; set; }
        public string TenDanToc { get; set; }

        [JsonIgnore]
        public virtual List<NhanSu> NhanSus { get; set; }

        [JsonIgnore]
        public virtual List<HocSinh> HocSinhs { get; set; }
    }
}