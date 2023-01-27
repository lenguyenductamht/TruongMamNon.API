using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class ChiTietPhieuNhapThucPhamRepository : IChiTietPhieuNhapThucPhamRepository
    {
        private readonly TruongMamNonDbContext _context;

        public ChiTietPhieuNhapThucPhamRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<ChiTietPhieuNhapThucPham> AddChiTietPhieuNhapThucPham(ChiTietPhieuNhapThucPham request)
        {
            var chiTietPhieuNhapThucPham = await _context.ChiTietPhieuNhapThucPhams.AddAsync(request);
            await _context.SaveChangesAsync();
            return chiTietPhieuNhapThucPham.Entity;
        }

        public async Task<ChiTietPhieuNhapThucPham> DeleteChiTietPhieuNhapThucPham(long maPhieuNhapThucPham, int maThucPham)
        {
            var chiTietPhieuNhapThucPham = await GetChiTietPhieuNhapThucPham(maPhieuNhapThucPham, maThucPham);
            if (chiTietPhieuNhapThucPham != null)
            {
                _context.ChiTietPhieuNhapThucPhams.Remove(chiTietPhieuNhapThucPham);
                await _context.SaveChangesAsync();
                return chiTietPhieuNhapThucPham;
            }
            return null;
        }

        public async Task<bool> Exists(long maPhieuNhapThucPham, int maThucPham)
        {
            return await _context.ChiTietPhieuNhapThucPhams.AnyAsync(x => x.MaPhieuNhapThucPham == maPhieuNhapThucPham && x.MaThucPham == maThucPham);
        }

        public async Task<ChiTietPhieuNhapThucPham> GetChiTietPhieuNhapThucPham(long maPhieuNhapThucPham, int maThucPham)
        {
            return await _context.ChiTietPhieuNhapThucPhams.FirstOrDefaultAsync(x => x.MaPhieuNhapThucPham == maPhieuNhapThucPham && x.MaThucPham == maThucPham);
        }

        public async Task<List<ChiTietPhieuNhapThucPham>> GetChiTietPhieuNhapThucPhams()
        {
            return await _context.ChiTietPhieuNhapThucPhams.ToListAsync();
        }

        public async Task<ChiTietPhieuNhapThucPham> UpdateChiTietPhieuNhapThucPham(long maPhieuNhapThucPham, int maThucPham, ChiTietPhieuNhapThucPham request)
        {
            var chiTietPhieuNhapThucPham = await GetChiTietPhieuNhapThucPham(maPhieuNhapThucPham, maThucPham);
            if (chiTietPhieuNhapThucPham != null)
            {
                chiTietPhieuNhapThucPham.DonGia = request.DonGia;
                chiTietPhieuNhapThucPham.SoLuong = request.SoLuong;
                await _context.SaveChangesAsync();
                return chiTietPhieuNhapThucPham;
            }
            return null;
        }
    }
}