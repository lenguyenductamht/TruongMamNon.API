using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class ChiTietPhieuXuatThucPhamRepository : IChiTietPhieuXuatThucPhamRepository
    {
        private readonly TruongMamNonDbContext _context;

        public ChiTietPhieuXuatThucPhamRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<ChiTietPhieuXuatThucPham> AddChiTietPhieuXuatThucPham(ChiTietPhieuXuatThucPham request)
        {
            var chiTietPhieuXuatThucPham = await _context.ChiTietPhieuXuatThucPhams.AddAsync(request);
            await _context.SaveChangesAsync();
            return chiTietPhieuXuatThucPham.Entity;
        }

        public async Task<ChiTietPhieuXuatThucPham> DeleteChiTietPhieuXuatThucPham(long maPhieuXuatThucPham, int maThucPham)
        {
            var chiTietPhieuXuatThucPham = await GetChiTietPhieuXuatThucPham(maPhieuXuatThucPham, maThucPham);
            if (chiTietPhieuXuatThucPham != null)
            {
                _context.ChiTietPhieuXuatThucPhams.Remove(chiTietPhieuXuatThucPham);
                await _context.SaveChangesAsync();
                return chiTietPhieuXuatThucPham;
            }
            return null;
        }

        public async Task<bool> Exists(long maPhieuXuatThucPham, int maThucPham)
        {
            return await _context.ChiTietPhieuXuatThucPhams.AnyAsync(x => x.MaPhieuXuatThucPham == maPhieuXuatThucPham && x.MaThucPham == maThucPham);
        }

        public async Task<ChiTietPhieuXuatThucPham> GetChiTietPhieuXuatThucPham(long maPhieuXuatThucPham, int maThucPham)
        {
            return await _context.ChiTietPhieuXuatThucPhams.FirstOrDefaultAsync(x => x.MaPhieuXuatThucPham == maPhieuXuatThucPham && x.MaThucPham == maThucPham);
        }

        public async Task<List<ChiTietPhieuXuatThucPham>> GetChiTietPhieuXuatThucPhamsByMaPhieuXuatThucPham(long maPhieuXuatThucPham)
        {
            return await _context.ChiTietPhieuXuatThucPhams.Where(x => x.MaPhieuXuatThucPham == maPhieuXuatThucPham).Include(x => x.ThucPham).ToListAsync();
        }

        public async Task<ChiTietPhieuXuatThucPham> UpdateChiTietPhieuXuatThucPham(long maPhieuXuatThucPham, int maThucPham, ChiTietPhieuXuatThucPham request)
        {
            var chiTietPhieuXuatThucPham = await GetChiTietPhieuXuatThucPham(maPhieuXuatThucPham, maThucPham);
            if (chiTietPhieuXuatThucPham != null)
            {
                chiTietPhieuXuatThucPham.SoLuong = request.SoLuong;
                await _context.SaveChangesAsync();
                return chiTietPhieuXuatThucPham;
            }
            return null;
        }
    }
}