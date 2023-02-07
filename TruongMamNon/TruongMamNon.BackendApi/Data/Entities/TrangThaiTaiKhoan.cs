using Newtonsoft.Json;

namespace TruongMamNon.BackendApi.Data.Entities
{
    public class TrangThaiTaiKhoan
    {
        public string MaTrangThai { get; set; }
        public string TenTrangThai { get; set; }

        [JsonIgnore]
        public virtual List<HocSinh> HocSinhs { get; set; }
        [JsonIgnore]
        public virtual List<NhanSu> NhanSus { get; set; }
    }
}