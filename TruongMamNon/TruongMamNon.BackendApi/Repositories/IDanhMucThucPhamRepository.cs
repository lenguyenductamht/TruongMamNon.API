using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface IDanhMucThucPhamRepository
    {
        Task<List<DanhMucThucPham>> GetDanhMucThucPhams();
    }
}