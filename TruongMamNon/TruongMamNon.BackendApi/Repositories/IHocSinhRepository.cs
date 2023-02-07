using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface IHocSinhRepository
    {
        Task<HocSinh> AddHocSinh(HocSinh request);

        Task<HocSinh> DeleteHocSinh(long maHocSinh);

        Task<bool> Exists(long maHocSinh);

        Task<List<HocSinh>> GetHocSinhs();

        Task<List<HocSinh>> GetHocSinhsByKhoiLop(int maKhoiLop);

        Task<List<HocSinh>> GetHocSinhsByLopHoc(int maLopHoc);

        Task<HocSinh> GetHocSinh(long maHocSinh);

        Task<HocSinh> UpdateHocSinh(long maHocSinh, HocSinh request);
    }
}