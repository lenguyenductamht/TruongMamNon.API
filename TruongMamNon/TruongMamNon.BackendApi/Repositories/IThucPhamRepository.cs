using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface IThucPhamRepository
    {
        Task<ThucPham> AddThucPham(ThucPham request);

        Task<ThucPham> DeleteThucPham(int maThucPham);

        Task<bool> Exists(int maThucPham);

        Task<List<ThucPham>> GetThucPhams();

        Task<ThucPham> GetThucPham(int maThucPham);

        Task<ThucPham> UpdateThucPham(int maThucPham, ThucPham request);

        Task<ThucPham> TangSoLuong(int maThucPham, double soLuongTang);
    }
}