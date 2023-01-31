using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface IPhieuXuatThucPhamRepository
    {
        Task<PhieuXuatThucPham> AddPhieuXuatThucPham(PhieuXuatThucPham request);

        Task<PhieuXuatThucPham> DeletePhieuXuatThucPham(int maPhieuXuatThucPham);

        Task<bool> Exists(int maPhieuXuatThucPham);

        Task<List<PhieuXuatThucPham>> GetPhieuXuatThucPhams();

        Task<PhieuXuatThucPham> GetPhieuXuatThucPham(int maPhieuXuatThucPham);

        Task<PhieuXuatThucPham> UpdatePhieuXuatThucPham(int maPhieuXuatThucPham, PhieuXuatThucPham request);
    }
}