using Newtonsoft.Json;

namespace TruongMamNon.BackendApi.Data.Entities
{
    public class TrangThaiHoc
    {
        public string MaTrangThai { get; set; }
        public string TenTrangThai { get; set; }

        [JsonIgnore]
        public virtual List<HocSinh> HocSinhs { get; set; }
    }
}