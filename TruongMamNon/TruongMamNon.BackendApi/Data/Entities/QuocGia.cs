using Newtonsoft.Json;

namespace TruongMamNon.BackendApi.Data.Entities
{
    public class QuocGia
    {
        public string MaQuocGia { get; set; }

        public string TenQuocGia { get; set; }

        [JsonIgnore]
        public virtual List<NhanSu> NhanSus { get; set; }

        [JsonIgnore]
        public virtual List<HocSinh> HocSinhs { get; set; }
    }
}