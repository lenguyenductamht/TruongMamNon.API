using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class PhieuXuatThucPhamRepository : IPhieuXuatThucPhamRepository
    {
        private readonly TruongMamNonDbContext _context;

        public PhieuXuatThucPhamRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<PhieuXuatThucPham> AddPhieuXuatThucPham(PhieuXuatThucPham request)
        {
            var phieuXuatThucPham = await _context.PhieuXuatThucPhams.AddAsync(request);
            await _context.SaveChangesAsync();
            return phieuXuatThucPham.Entity;
        }

        public async Task<PhieuXuatThucPham> DeletePhieuXuatThucPham(int maPhieuXuatThucPham)
        {
            var phieuXuatThucPham = await GetPhieuXuatThucPham(maPhieuXuatThucPham);
            if (phieuXuatThucPham != null)
            {
                _context.PhieuXuatThucPhams.Remove(phieuXuatThucPham);
                await _context.SaveChangesAsync();
                return phieuXuatThucPham;
            }
            return null;
        }

        public async Task<bool> Exists(int maPhieuXuatThucPham)
        {
            return await _context.PhieuXuatThucPhams.AnyAsync(x => x.MaPhieuXuatThucPham == maPhieuXuatThucPham);
        }

        public async Task<PhieuXuatThucPham> GetPhieuXuatThucPham(int maPhieuXuatThucPham)
        {
            return await _context.PhieuXuatThucPhams.FirstOrDefaultAsync(x => x.MaPhieuXuatThucPham == maPhieuXuatThucPham);
        }

        public async Task<List<PhieuXuatThucPham>> GetPhieuXuatThucPhams()
        {
            return await _context.PhieuXuatThucPhams.Include(x => x.NguoiXuat).OrderByDescending(x => x.NgayXuat).ToListAsync();
        }

        public async Task<PhieuXuatThucPham> UpdatePhieuXuatThucPham(int maPhieuXuatThucPham, PhieuXuatThucPham request)
        {
            var phieuXuatThucPham = await GetPhieuXuatThucPham(maPhieuXuatThucPham);
            if (phieuXuatThucPham != null)
            {
                phieuXuatThucPham.NgayXuat = request.NgayXuat;
                phieuXuatThucPham.MaNguoiXuat = request.MaNguoiXuat;
                phieuXuatThucPham.GhiChu = request.GhiChu;
                phieuXuatThucPham.TrangThai = request.TrangThai;
                await _context.SaveChangesAsync();
                return phieuXuatThucPham;
            }
            return null;
        }
    }
}