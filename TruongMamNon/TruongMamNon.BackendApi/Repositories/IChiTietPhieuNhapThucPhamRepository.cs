using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface IChiTietPhieuNhapThucPhamRepository
    {
        Task<ChiTietPhieuNhapThucPham> AddChiTietPhieuNhapThucPham(ChiTietPhieuNhapThucPham request);

        Task<ChiTietPhieuNhapThucPham> DeleteChiTietPhieuNhapThucPham(long maPhieuNhapThucPham, int maThucPham);

        Task<bool> Exists(long maPhieuNhapThucPham, int maThucPham);

        Task<List<ChiTietPhieuNhapThucPham>> GetChiTietPhieuNhapThucPhamsByMaPhieuNhapThucPham(long maPhieuNhapThucPham);

        Task<ChiTietPhieuNhapThucPham> GetChiTietPhieuNhapThucPham(long maPhieuNhapThucPham, int maThucPham);

        Task<ChiTietPhieuNhapThucPham> UpdateChiTietPhieuNhapThucPham(long maPhieuNhapThucPham, int maThucPham, ChiTietPhieuNhapThucPham request);
    }
}