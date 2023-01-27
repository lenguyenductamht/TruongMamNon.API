using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class PhieuNhapThucPhamRepository : IPhieuNhapThucPhamRepository
    {
        private readonly TruongMamNonDbContext _context;

        public PhieuNhapThucPhamRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<PhieuNhapThucPham> AddPhieuNhapThucPham(PhieuNhapThucPham request)
        {
            var phieuNhapThucPham = await _context.PhieuNhapThucPhams.AddAsync(request);
            await _context.SaveChangesAsync();
            return phieuNhapThucPham.Entity;
        }

        public async Task<PhieuNhapThucPham> DeletePhieuNhapThucPham(int maPhieuNhapThucPham)
        {
            var phieuNhapThucPham = await GetPhieuNhapThucPham(maPhieuNhapThucPham);
            if (phieuNhapThucPham != null)
            {
                _context.PhieuNhapThucPhams.Remove(phieuNhapThucPham);
                await _context.SaveChangesAsync();
                return phieuNhapThucPham;
            }
            return null;
        }

        public async Task<bool> Exists(int maPhieuNhapThucPham)
        {
            return await _context.PhieuNhapThucPhams.AnyAsync(x => x.MaPhieuNhapThucPham == maPhieuNhapThucPham);
        }

        public async Task<PhieuNhapThucPham> GetPhieuNhapThucPham(int maPhieuNhapThucPham)
        {
            return await _context.PhieuNhapThucPhams.FirstOrDefaultAsync(x => x.MaPhieuNhapThucPham == maPhieuNhapThucPham);
        }

        public async Task<List<PhieuNhapThucPham>> GetPhieuNhapThucPhams()
        {
            return await _context.PhieuNhapThucPhams.Include(x => x.NguoiNhap).OrderByDescending(x => x.NgayNhap).ToListAsync();
        }

        public async Task<PhieuNhapThucPham> UpdatePhieuNhapThucPham(int maPhieuNhapThucPham, PhieuNhapThucPham request)
        {
            var phieuNhapThucPham = await GetPhieuNhapThucPham(maPhieuNhapThucPham);
            if (phieuNhapThucPham != null)
            {
                phieuNhapThucPham.NgayNhap = request.NgayNhap;
                phieuNhapThucPham.MaNguoiNhap = request.MaNguoiNhap;
                phieuNhapThucPham.GhiChu = request.GhiChu;
                phieuNhapThucPham.TrangThai = request.TrangThai;
                await _context.SaveChangesAsync();
                return phieuNhapThucPham;
            }
            return null;
        }
    }
}