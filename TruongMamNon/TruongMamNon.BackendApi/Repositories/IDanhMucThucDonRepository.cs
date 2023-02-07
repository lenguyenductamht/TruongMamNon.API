using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface IDanhMucThucDonRepository
    {
        Task<DanhMucThucDon> AddDanhMucThucDon(DanhMucThucDon request);

        Task<DanhMucThucDon> DeleteDanhMucThucDon(int maDanhMucThucDon);

        Task<bool> Exists(int maDanhMucThucDon);

        Task<List<DanhMucThucDon>> GetDanhMucThucDons();

        Task<DanhMucThucDon> GetDanhMucThucDon(int maDanhMucThucDon);

        Task<DanhMucThucDon> UpdateDanhMucThucDon(int maDanhMucThucDon, DanhMucThucDon request);
    }
}