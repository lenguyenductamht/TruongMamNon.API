using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface IChiTietPhieuXuatThucPhamRepository
    {
        Task<ChiTietPhieuXuatThucPham> AddChiTietPhieuXuatThucPham(ChiTietPhieuXuatThucPham request);

        Task<ChiTietPhieuXuatThucPham> DeleteChiTietPhieuXuatThucPham(long maPhieuXuatThucPham, int maThucPham);

        Task<bool> Exists(long maPhieuXuatThucPham, int maThucPham);

        Task<List<ChiTietPhieuXuatThucPham>> GetChiTietPhieuXuatThucPhamsByMaPhieuXuatThucPham(long maPhieuXuatThucPham);

        Task<ChiTietPhieuXuatThucPham> GetChiTietPhieuXuatThucPham(long maPhieuXuatThucPham, int maThucPham);

        Task<ChiTietPhieuXuatThucPham> UpdateChiTietPhieuXuatThucPham(long maPhieuXuatThucPham, int maThucPham, ChiTietPhieuXuatThucPham request);
    }
}