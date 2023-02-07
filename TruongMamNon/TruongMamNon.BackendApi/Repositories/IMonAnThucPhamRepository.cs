using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface IMonAnThucPhamRepository
    {
        Task<MonAnThucPham> AddMonAnThucPham(MonAnThucPham request);

        Task<MonAnThucPham> DeleteMonAnThucPham(int maMonAn, int maThucPham);

        Task<bool> Exists(int maMonAn, int maThucPham);

        Task<List<MonAnThucPham>> GetMonAnThucPhamsByMonAn(int maMonAn);

        Task<MonAnThucPham> GetMonAnThucPham(int maMonAn, int maThucPham);

        Task<MonAnThucPham> UpdateMonAnThucPham(int maMonAn, int maThucPham, MonAnThucPham request);
    }
}