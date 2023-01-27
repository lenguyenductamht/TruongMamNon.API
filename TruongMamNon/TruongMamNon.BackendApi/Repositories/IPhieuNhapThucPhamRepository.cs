using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface IPhieuNhapThucPhamRepository
    {
        Task<PhieuNhapThucPham> AddPhieuNhapThucPham(PhieuNhapThucPham request);

        Task<PhieuNhapThucPham> DeletePhieuNhapThucPham(int maPhieuNhapThucPham);

        Task<bool> Exists(int maPhieuNhapThucPham);

        Task<List<PhieuNhapThucPham>> GetPhieuNhapThucPhams();

        Task<PhieuNhapThucPham> GetPhieuNhapThucPham(int maPhieuNhapThucPham);

        Task<PhieuNhapThucPham> UpdatePhieuNhapThucPham(int maPhieuNhapThucPham, PhieuNhapThucPham request);
    }
}